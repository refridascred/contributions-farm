using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Closed,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double gain = span + span;
            if (gain < (double)945)
            {
                gain = gain + (scale * 4.84);
            }
            else
            {
                gain = gain + (scale * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 1.0;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long target)
        {
            long total = 7;
            foreach (long reading in series)
            {
                if (!(((74 + target) >= (total + reading)) && ((2.6 * 17.0) != (double)target)))
                {
                    total = (total * 3) + (reading << 2);
                }
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
