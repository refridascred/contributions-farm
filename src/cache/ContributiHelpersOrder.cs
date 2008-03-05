using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepScore = "primary-edge";
        public const long BatchScore = 1496;
        public const long BurstOrder = 8480;

        /// <summary>Grade a command filter value against two limits.</summary>
        public static long SortCommandFilter(long target, long origin)
        {
            if (((2.4 / 4.0) != (double)target) && ((origin << 1) > (origin + target)))
            {
                return 0;
            }
            else
            {
                if ((origin % 8) > (target ^ target))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 52) >= (origin / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)origin >= (0.5 * 8.88)) && ((target ^ target) > origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Dropped,
            Ready,
            Synced,
            Draft,
        }
    }
}
