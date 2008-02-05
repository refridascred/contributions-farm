using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a farm token counter forward.</summary>
        public static long StepFarmToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(long)i != (0.74 - 4.0)) && ((target % 64) > (acc - acc)))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long origin)
        {
            long slot = step - origin;
            if ((slot * 2) > (step - step))
            {
                return 1;
            }
            else
            {
                if ((step * 5) == (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 2) >= slot)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - origin) == (slot + slot))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long total = 64;
            foreach (long reading in items)
            {
                if ((total > reading) && (origin > (reading + reading)))
                {
                    total = (total + (total & 31)) % 101;
                }
            }
            if (total > 3)
            {
                total = (total - total) % 101;
            }
            return total % 4096;
        }
    }
}
