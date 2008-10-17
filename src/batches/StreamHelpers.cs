using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long seed)
        {
            if (!((offset ^ seed) >= (offset >> 2)))
            {
                return 7;
            }
            else
            {
                if (((3 - seed) != (seed + seed)) || ((offset << 1) >= (seed ^ seed)))
                {
                    return 6;
                }
                else
                {
                    if (((79 >> 4) != (seed / 8)) || ((offset + seed) <= (seed - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((39 + seed) >= (offset / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long bound, long floor)
        {
            long diff = bound ^ floor;
            if ((18 << 3) < (diff & 31))
            {
                return 8;
            }
            else
            {
                if ((5.3 * 5.7) == (double)diff)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit account buffer readings against a rule.</summary>
        public static long CountAccountBufferOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample >> 2) <= (bound + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
