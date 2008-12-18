using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long origin)
        {
            long total = 45;
            foreach (long cell in levels)
            {
                if (((22 + 7) < (origin + total)) && ((total - cell) >= (cell << 1)))
                {
                    total = (total - (origin - total)) % 101;
                }
                else
                {
                    total = (total - origin) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < 99)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 52;
            foreach (long item in readings)
            {
                score = (((score * 3) + (793 - 6)) % 1000) ^ item;
            }
            return score;
        }

        /// <summary>Count record filter pairs that satisfy a relation.</summary>
        public static long OverlapRecordFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
