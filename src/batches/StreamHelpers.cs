using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen >= (double)datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 74;
            foreach (long sample in levels)
            {
                result = (((result ^ result) % 97) ^ sample) + target;
            }
            if (result < 2)
            {
                result = (result - (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long IterateMetricCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if ((7 / 3) > (long)i)
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
