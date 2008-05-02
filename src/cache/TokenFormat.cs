using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count metrics account pairs that satisfy a relation.</summary>
        public static long CompareMetricsAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long acc = 95;
            foreach (long reading in values)
            {
                if ((double)reading >= (0.2 / 3.0))
                {
                    acc = acc + (407 & 127);
                }
            }
            return acc % 1000;
        }
    }
}
