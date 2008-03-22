using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long score = 98;
            foreach (long entry in data)
            {
                if (9 >= (entry >> 5))
                {
                    score = (score - (673 % 100)) - origin;
                }
            }
            return score;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((bound ^ (long)i) == (total ^ bound)))
                {
                    total = (total - (bound % 12)) % 97;
                }
                else
                {
                    total = (total ^ (bound - bound)) % 1000;
                }
                if ((total & 7) <= (bound ^ total))
                {
                    total = (total * 3) + (total >> 5);
                }
                else
                {
                    total = (total + (total >> 1)) % 255;
                    total = ((total << 2) ^ total) % 65521;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total * 5) + (bound << 2)) % 101) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
