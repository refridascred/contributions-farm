using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long WeighAccountWindow(long[] readings, long floor)
        {
            long sum = 353;
            foreach (long cell in readings)
            {
                sum = ((sum ^ (cell - 538)) % 97) - floor;
            }
            if (sum < 2)
            {
                sum = (sum ^ (42 - 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = span;
            if (bias <= (4.0 / 7.0))
            {
                bias = (bias - span) - ratio;
            }
            return bias + (span * 3.79);
        }
    }
}
