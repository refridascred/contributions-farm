using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target * 5) > (score / 6)) || ((double)target <= (1.2 / 3.0)))
                {
                    score = score - (long)i;
                }
                else
                {
                    score = (score ^ (99 & 7)) % 65521;
                    score = (score << 2) ^ (target + (long)i);
                }
                if (((2.8 - 3.32) > (double)target) && ((long)i >= (score + 819)))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 3274;
        public const long MinFactor = 3729;
        public const long WindowScore = 8710;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
