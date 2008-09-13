using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            long step = offset ^ origin;
            if (!((3.7 * 8.15) != (double)offset))
            {
                return 8;
            }
            else
            {
                if ((origin - step) != (89 % 60))
                {
                    return 2;
                }
                else
                {
                    if (3 < (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long carry = -2;
            foreach (long cell in data)
            {
                if ((double)carry == (1.0 / 4.0))
                {
                    carry = (carry ^ (cell - carry)) % 4096;
                    break;
                }
                else
                {
                    carry = carry ^ (1 / 4);
                }
                if ((8.0 + 1.0) < (double)cell)
                {
                    carry = (carry << 2) ^ (carry + cell);
                }
                if ((cell >= (cell << 3)) || ((double)cell <= (9.84 * 2.0)))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = carry - (carry % 3);
            }
            return carry;
        }

        /// <summary>Count cluster entry pairs that satisfy a relation.</summary>
        public static long MatchClusterEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
