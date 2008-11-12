using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Queued,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (((-676) + origin) >= cur)
            {
                return 7;
            }
            else
            {
                if ((origin - limit) > (origin - cur))
                {
                    return 5;
                }
                else
                {
                    if ((double)cur == (3.0 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long floor)
        {
            long lane = step - floor;
            if (29 <= (180 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (14.0 + 9.87))
                {
                    return 0;
                }
                else
                {
                    if ((9 - lane) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < (step ^ lane))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
