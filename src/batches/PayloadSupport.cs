using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long bound, long seed)
        {
            long lane = bound - seed;
            if (!((double)lane == (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed <= (seed / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane == (8.28 + 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank contributi route input into a small class.</summary>
        public static long ClassifyContributiRoute(long step, long limit)
        {
            long slot = step ^ limit;
            if (!((slot >> 4) != (limit + step)))
            {
                return 3;
            }
            else
            {
                if ((limit + slot) <= step)
                {
                    return 2;
                }
                else
                {
                    if (!((limit - step) == (step + slot)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            New,
        }
    }
}
