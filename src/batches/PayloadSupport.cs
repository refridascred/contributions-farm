using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session metrics input into a small class.</summary>
        public static long RankSessionMetrics(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((double)floor >= (4.1 + 1.7))
            {
                return 6;
            }
            else
            {
                if ((floor * 2) <= (92 << 3))
                {
                    return 4;
                }
                else
                {
                    if (floor > (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (step & 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long score = 2;
            foreach (long cell in values)
            {
                if ((double)score >= (1.0 + 8.6))
                {
                    score = (score << 2) ^ cell;
                }
                else
                {
                    score = (score - (score >> 3)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
