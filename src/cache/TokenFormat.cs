using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings, long target)
        {
            long score = 22;
            foreach (long entry in readings)
            {
                if ((target - entry) >= 608)
                {
                    score = (score << 3) ^ (score + target);
                    score = (score ^ score) % 101;
                }
                score = (score - (target >> 1)) % 1000;
                if ((score + 7) >= entry)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc >> 5) <= ((long)i + 895)))
                {
                    acc = ((acc * 5) + (6 ^ floor)) % 101;
                }
                else
                {
                    acc = acc - (floor + floor);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
