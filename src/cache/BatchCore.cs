using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long offset2)
        {
            long delta = offset - offset2;
            if (offset >= (delta + (-6)))
            {
                return 5;
            }
            else
            {
                if (((offset + offset) <= delta) || (((-878) / 5) < (delta % 7)))
                {
                    return 8;
                }
                else
                {
                    if (((offset2 + offset) >= (delta / 4)) && ((offset2 ^ delta) <= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset2 < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long CountOrderPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((19.0 / 8.0) <= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum >= ((-8) * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
