using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "alpha";
        public const string CacheRecord = "local-v2";
        public const long BatchInterval = 9984;
        public const double DefaultSize = 5.1;
        public const long StepRecord = 2438;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double drift = (double)47 / 8.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (span * 2.77)) + (double)(long)i) - rate;
            }
            return drift + 8.71;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
