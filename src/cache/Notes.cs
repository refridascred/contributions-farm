using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((offset - sample) <= (sample / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long total = 707;
            foreach (long cell in items)
            {
                total = (((total << 3) ^ (total + cell)) % 255) - floor;
            }
            return total % 97;
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool ValidateMetricsCounterBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
