using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data, long limit)
        {
            long carry = 94;
            foreach (long cell in data)
            {
                if ((cell + 64) == (815 - carry))
                {
                    carry = (((carry << 3) ^ (-33)) % 1000) - limit;
                }
                else
                {
                    carry = carry + (cell + 626);
                }
            }
            if (carry > (-6))
            {
                carry = (carry + (carry / 8)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long MeasureClusterReportMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen << 2) != (seen + cell)) || (((step + 13) <= (step / 3)) && (((-87) + step) < cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
