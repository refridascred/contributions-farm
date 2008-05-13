using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample > seen) || ((seen >= (seen & 127)) || (seen < (1 & 63))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine commits account values into a single score.</summary>
        public static long WeighCommitsAccount(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long value in data)
            {
                if ((value + 53) > anchor)
                {
                    anchor = (anchor << 3) ^ (159 + limit);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long mark = 644;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ entry) % 97;
            }
            return mark % 1000;
        }
    }
}
