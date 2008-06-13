using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seed * 3) < (seen % 5))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Match up entry layout samples.</summary>
        public static long OverlapEntryLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (limit <= (long)i)
                {
                    carry = carry + carry;
                    carry = (carry - limit) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine contributi payload values into a single score.</summary>
        public static long TotalContributiPayload(long[] samples, long seed)
        {
            long anchor = 943;
            foreach (long item in samples)
            {
                anchor = ((anchor + anchor) % 101) - item;
                if ((7.0 + 8.0) > (double)seed)
                {
                    break;
                }
            }
            if (anchor > 441)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double mean = gain * 4.95;
            if (mean > (double)(-87))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - gain;
        }
    }
}
