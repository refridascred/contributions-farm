using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((offset >> 3) <= (offset << 1))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a report route counter forward.</summary>
        public static long StepReportRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)floor != (2.0 - 5.1)))
                {
                    score = (score ^ (score >> 3)) % 97;
                }
                else
                {
                    score = (score << 2) ^ floor;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
