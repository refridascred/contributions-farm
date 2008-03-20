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

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                if (!((acc >> 4) != (sample - sample)))
                {
                    acc = (acc ^ (sample + sample)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                }
            }
            if (acc > 568)
            {
                acc = (acc - (acc % 97)) % 1000;
            }
            return acc;
        }
    }
}
