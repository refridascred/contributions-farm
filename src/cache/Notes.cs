using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if ((double)floor <= 4.1)
            {
                return 6;
            }
            else
            {
                if (((2.07 + 15.0) < (double)target) || ((target / 5) >= (floor >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (9.0 >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((1.96 + 6.9) >= (double)reading)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (diff > floor)
            {
                return 8;
            }
            else
            {
                if (((diff << 3) != (floor + diff)) || ((8 ^ floor) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((17 / 4) == (limit + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches % 8) <= (matches << 1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
