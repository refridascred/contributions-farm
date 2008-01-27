using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            if (((bound - bound) >= (0 << 3)) && ((bound >> 3) == (bound + seed)))
            {
                return 8;
            }
            else
            {
                if ((-42) >= (3 + bound))
                {
                    return 3;
                }
                else
                {
                    if (7.32 >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) == (357 + 498))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((17.0 * 9.0) <= (double)reading)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + ((long)i >> 4)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Synced,
            Ready,
            Done,
            Idle,
        }
    }
}
