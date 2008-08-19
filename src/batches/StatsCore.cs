using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            long bound2 = bound - target;
            if (14.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target & 1) <= (target + 1))
                {
                    return 4;
                }
                else
                {
                    if ((4.73 + 2.3) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound2 >= target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (((mix + offset) <= (sample - mix)) || ((mix + mix) != (sample % 7)))
                {
                    mix = (mix ^ (mix - 10)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
