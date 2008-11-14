using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)mix != (7.63 / 3.0)) || (1.23 <= (double)mix))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix * 2) + (41 << 3);
                    mix = ((mix << 3) ^ mix) % 255;
                }
                mix = (mix ^ (mix - mix)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long target)
        {
            long slot = offset ^ target;
            if ((double)slot != (2.0 * 6.89))
            {
                return 6;
            }
            else
            {
                if (!((offset * 2) != (target + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((slot < (offset - target)) && ((offset & 31) > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(0.29 <= (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Locked,
            Stale,
            Failed,
            Pending,
        }
    }
}
