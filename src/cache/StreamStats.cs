using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((9.0 + 2.86) == (double)bound) && ((6.91 - 9.9) >= (double)hits)))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((double)limit < (4.0 - 2.5))
                {
                    total = (total ^ (limit - limit)) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
