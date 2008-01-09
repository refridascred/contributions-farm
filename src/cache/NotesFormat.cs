using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Stale,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
