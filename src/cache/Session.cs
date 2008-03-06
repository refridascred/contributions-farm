using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((matches - matches) < (matches + cell)) && ((59 - cell) > matches)) || ((cell + (-9)) > (matches * 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route farm entries that pass the check.</summary>
        public static long AuditRouteFarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((4.78 - 11.0) == (double)item) || ((matches << 2) > item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (12.0 < (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - cell) <= cell)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
