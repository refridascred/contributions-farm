using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Failed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 - (gain / 4.0);
            }
            return bias2 + (gain * 6.8);
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            New,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
