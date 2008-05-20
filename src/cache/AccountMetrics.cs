using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + count) > count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item % 24) > (58 / 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (11.0 * 20.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value + value) > value) || ((value % 64) == (900 >> 3)))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
