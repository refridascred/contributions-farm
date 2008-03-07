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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double drift = bias / 5.0;
            if (drift < (bias * 9.43))
            {
                drift = (drift - bias) - scale;
            }
            else
            {
                drift = drift + (double)89;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift - bias)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
