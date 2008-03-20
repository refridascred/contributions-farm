using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of context checks readings.</summary>
        public static long WeighContextChecks(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((5.0 * 11.0) != (double)entry)
                {
                    anchor = (anchor << 3) ^ (entry % 10);
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
                anchor = (anchor - (entry << 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long limit)
        {
            long score = 578;
            foreach (long cell in series)
            {
                if (!((double)limit <= 7.5))
                {
                    score = score - (cell & 1);
                }
                if ((limit ^ score) >= limit)
                {
                    break;
                }
            }
            return score;
        }
    }
}
