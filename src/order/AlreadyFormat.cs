using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Derive the next already editor value from a seed.</summary>
        public static long RollAlreadyEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (395 > (total * 2))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long StepContributiAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((955 << 1) <= (value * 5)) && ((value - 98) > (297 - (-193)))) && !((8.1 / 9.0) != (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
