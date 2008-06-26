using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long SortBatchChecks(long floor, long origin)
        {
            if ((floor - 767) >= (2 - origin))
            {
                return 0;
            }
            else
            {
                if (floor <= (floor ^ 3))
                {
                    return 6;
                }
                else
                {
                    if ((20.0 * 9.39) < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - origin) == (215 * 4)) || (origin > (-7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "stable";
        public const long CacheFarm = 9827;
        public const long HardDepth = 1967;
        public const long SoftDepth = 8637;
        public const double BurstLevel = 31.13;

        /// <summary>Measure how many context graph samples are out of range.</summary>
        public static long MeasureContextGraphMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (4 <= cell)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
