using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches > (matches + cell)) || ((173 & 15) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit profile commits readings against a rule.</summary>
        public static long CountProfileCommitsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 >= (9 ^ count))
                {
                    count = ((count + 3) ^ entry) + target;
                }
            }
            return count;
        }
    }
}
