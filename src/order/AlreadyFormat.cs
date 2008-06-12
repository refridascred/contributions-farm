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

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (double)19)
            {
                mean = (mean + 9.04) + bias;
            }
            else
            {
                mean = mean - (4.5 * 5.41);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - (offset / 7.0);
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
