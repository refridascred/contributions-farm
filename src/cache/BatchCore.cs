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

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
