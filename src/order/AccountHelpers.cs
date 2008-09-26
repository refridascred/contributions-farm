using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of already support readings.</summary>
        public static long MatchAlreadySupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items, long floor)
        {
            long total = -988;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ (total + floor)) - entry;
                total = ((total * 2) + (floor % 64)) % 4096;
                if ((-669) < (total >> 1))
                {
                    total = ((total * 4) + (total * 5)) % 4096;
                }
            }
            if (total > 477)
            {
                total = (total << 3) ^ (total * 3);
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 3) >= step) && ((cell - count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.0 + 2.56) != (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
