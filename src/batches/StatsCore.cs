using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long floor2)
        {
            long bound = floor + floor2;
            if (!((bound + bound) > (bound & 1)))
            {
                return 4;
            }
            else
            {
                if (!((2.3 / 9.0) == (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 << 3) >= (8 / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound >= (floor & 15))
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
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if (limit > (gap + gap))
            {
                return 7;
            }
            else
            {
                if (((-306) - gap) == (0 ^ limit2))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 + 2.0) != (double)limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
