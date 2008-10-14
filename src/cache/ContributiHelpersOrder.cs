using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a profile account counter forward.</summary>
        public static long StepProfileAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                mix = mix - (target + mix);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            if (bound > (6 << 1))
            {
                return 6;
            }
            else
            {
                if (bound > step)
                {
                    return 2;
                }
                else
                {
                    if (bound >= (bound + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long GradeOrderStats(long target, long target2)
        {
            long diff = target - target2;
            if ((target << 3) <= (target2 & 31))
            {
                return 2;
            }
            else
            {
                if (!(target <= (298 - diff)))
                {
                    return 3;
                }
                else
                {
                    if (((diff ^ 5) <= (diff << 1)) || ((target2 % 16) >= (7 ^ target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target / 7) > (diff ^ 37))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
