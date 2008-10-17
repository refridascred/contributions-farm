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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4014;
        public const long WindowBatches = 8823;
        public const long BatchBatches = 1216;

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
