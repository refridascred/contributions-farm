using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit order format readings against a rule.</summary>
        public static long TallyOrderFormatMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "legacy-v2";
        public const string MaxSpan = "legacy";
        public const string DefaultSize = "primary-edge";
        public const double BatchMetric = 76.8;
        public const long MinCount = 349;

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long ClassifyChecksPayload(long origin, long seed)
        {
            if (seed >= origin)
            {
                return 4;
            }
            else
            {
                if ((origin ^ seed) == (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (origin <= (origin / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 2) == (seed >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
