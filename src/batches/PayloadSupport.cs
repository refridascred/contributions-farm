using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((bound2 * 3) == (719 + 0))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (8.0 / 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((56 + bound) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound2 ^ bound) >= (bound2 % 100))
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

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((19.0 + 7.13) == (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
