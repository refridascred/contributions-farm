using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a session farm sample.</summary>
        public static long FindSessionFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double gain = offset + bias;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count the batch route entries that pass the check.</summary>
        public static long TallyBatchRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((39 - datum) < datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            New,
            Paused,
        }
    }
}
