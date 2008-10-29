using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((18.0 - 7.79) != (double)hits)
                {
                    hits = ((hits + 1) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine channel account values into a single score.</summary>
        public static long DigestChannelAccount(long[] samples, long offset)
        {
            long acc = 5;
            foreach (long cell in samples)
            {
                if ((78 & 255) > acc)
                {
                    acc = ((((acc * 4) + (acc << 3)) % 97) ^ cell) - offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long step)
        {
            long cur = offset - step;
            if ((0.25 + 1.0) <= (double)cur)
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (step + cur))
                {
                    return 0;
                }
                else
                {
                    if (!((step % 8) != (offset >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
