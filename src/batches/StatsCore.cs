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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Idle,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - mix) % 65521;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long MeasureChecksReportOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell + (-46)) <= seen))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
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
