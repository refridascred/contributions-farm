using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long bound)
        {
            if ((bound / 9) == (bound % 8))
            {
                return 8;
            }
            else
            {
                if ((double)step != (6.73 - 2.84))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (bound + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Pending,
            Draft,
            Queued,
        }
    }
}
