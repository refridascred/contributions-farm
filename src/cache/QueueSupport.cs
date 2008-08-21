using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((((-612) + matches) >= floor) || ((reading / 6) != (matches + floor))) && !((matches + floor) != (reading + 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((6.0 - 9.9) != (double)hits)
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
