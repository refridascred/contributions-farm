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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
