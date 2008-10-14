using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Ready,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values, long offset)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((mix + offset) != (mix << 3))
                {
                    mix = (mix << 2) ^ (long)values.Length;
                }
                else
                {
                    mix = mix + (mix - (-50));
                }
                mix = (mix * 3) + (offset + mix);
                mix = (mix + mix) % 4096;
                if ((mix >= (value + offset)) && ((value % 100) > value))
                {
                    break;
                }
            }
            return mix % 4096;
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
