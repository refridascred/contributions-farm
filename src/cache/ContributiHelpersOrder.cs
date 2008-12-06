using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long StepQueueFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long bound)
        {
            if (((5.01 * 5.36) >= (9.5 + 1.0)) && ((origin ^ bound) == (bound - bound)))
            {
                return 1;
            }
            else
            {
                if ((25 + origin) != (bound / 3))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 8) != (8 + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(4 > (origin + bound)))
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
        }
    }
}
