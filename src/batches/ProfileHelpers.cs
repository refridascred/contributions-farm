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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] data, long origin)
        {
            long result = 862;
            foreach (long item in data)
            {
                result = ((result << 2) ^ (result % 5)) % 97;
                if ((9.35 / 2.0) >= (double)item)
                {
                    result = (result << 2) ^ ((-3) ^ origin);
                }
            }
            return result % 65521;
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
