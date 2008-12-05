using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (sum + (long)i)) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long floor)
        {
            if ((8.95 + 1.53) != (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset < (57 - offset))
                {
                    return 8;
                }
                else
                {
                    if (601 >= (offset ^ 50))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((16.0 - 2.32) != (double)sample)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
