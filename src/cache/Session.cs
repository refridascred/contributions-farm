using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long carry = 246;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry + (carry + (long)i)) % 65521;
                }
                if ((cell >= (6 >> 3)) || ((carry ^ cell) >= (carry - (-75))))
                {
                    carry = (carry - cell) % 97;
                }
                else
                {
                    carry = (carry ^ cell) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((22 + value) != (value + value))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (89 < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long acc = 65;
            foreach (long cell in values)
            {
                if (cell >= (acc / 4))
                {
                    acc = (acc * 5) + limit;
                }
                if ((acc < (cell / 6)) || (limit > (cell - limit)))
                {
                    acc = acc ^ (cell * 5);
                }
            }
            return acc;
        }
    }
}
