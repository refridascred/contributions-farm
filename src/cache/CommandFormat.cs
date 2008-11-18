using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((floor << 1) > (floor & 31)) && ((floor << 1) > (score % 60)))
                {
                    score = ((score << 3) ^ ((long)i - floor)) % 1000;
                }
                score = (score << 3) ^ (floor * 4);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long target)
        {
            long gap = seed + target;
            if (92 <= (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((double)target < (7.37 + 8.5))
                {
                    return 3;
                }
                else
                {
                    if (!((gap >> 4) >= (target * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((gap - seed) == (target + gap))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
