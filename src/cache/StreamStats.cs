using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long offset, long target)
        {
            long delta = offset ^ target;
            if ((target - 14) <= (target + 88))
            {
                return 2;
            }
            else
            {
                if (((target * 4) < target) || ((delta ^ delta) >= (25 ^ 56)))
                {
                    return 6;
                }
                else
                {
                    if (((delta >> 5) < (1 % 7)) && ((target >> 2) != (367 / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.5 * 16.0) != (double)delta)
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
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 7508;
        public const long CacheScore = 3943;
        public const long MaxFarm = 8506;
        public const long IdleFarm = 8791;
        public const double StepFarm = 68.44;
    }
}
