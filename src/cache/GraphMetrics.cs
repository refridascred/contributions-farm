using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length - value) > (count ^ value)) || ((value > (value ^ 0)) && (((long)data.Length + value) > (-73))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long anchor = 77;
            foreach (long reading in levels)
            {
                anchor = (anchor - (58 * 4)) ^ reading;
            }
            if (anchor > (-670))
            {
                anchor = anchor ^ (anchor << 1);
            }
            return anchor % 4096;
        }

        /// <summary>Match up graph entry samples.</summary>
        public static long OverlapGraphEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 7598;
        public const long IdleWidth = 5129;
        public const long HardCommand = 9527;
    }
}
