using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue channel input into a small class.</summary>
        public static long GradeQueueChannel(long target, long origin)
        {
            long lane = target ^ origin;
            if (!((double)origin >= 2.5))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) != (8 - origin))
                {
                    return 2;
                }
                else
                {
                    if (((target - 32) > (638 << 2)) && ((origin / 4) > (lane - lane)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane / 4) <= (origin >> 1))
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstLevel = 7320;
        public const long RetryEntry = 8929;
        public const double BatchInterval = 88.35;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Done,
            New,
            Locked,
        }
    }
}
