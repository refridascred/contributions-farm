using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i / 3) != ((long)i + bound))
                {
                    carry = (carry ^ (bound + 14)) % 1000;
                    continue;
                }
                else
                {
                    long tally = bound * 4;
                    carry = (carry << 2) ^ (tally + tally);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long LookupBufferCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum << 3) != (seen + datum)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
