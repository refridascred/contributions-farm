using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long sum = 58;
            foreach (long datum in values)
            {
                if ((datum & 7) != (sum << 1))
                {
                    sum = (sum + (datum >> 1)) % 255;
                }
            }
            if (sum < (-813))
            {
                sum = ((sum * 4) + (sum ^ sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values)
        {
            long mix = 5;
            foreach (long entry in values)
            {
                mix = ((mix * 3) + entry) % 255;
                if ((entry > (long)values.Length) || ((mix - entry) < mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double mean = (double)(99 >> 3);
            if (mean > mean)
            {
                mean = (mean - mean) - rate;
            }
            else
            {
                mean = mean + (double)18;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - 4.4;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
