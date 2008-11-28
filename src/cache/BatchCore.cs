using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 3) <= hits)
                {
                    hits = ((hits + 1) ^ value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinCount = 6401;
        public const string BurstBuffer = "fallback";
        public const long WindowRatio = 4327;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor - 52) > (long)i)
                {
                    anchor = anchor ^ ((long)i & 31);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
