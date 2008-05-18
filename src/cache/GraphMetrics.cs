using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchFactor = 702;
        public const long BatchCount = 2456;
        public const double BaseContributi = 53.7;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next stats notes value from a seed.</summary>
        public static long RollStatsNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!(39 >= ((long)i >> 5)))
                {
                    carry = (carry + 99) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ 7;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (offset - mark)) % 255;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
