using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Draft,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long bound2)
        {
            long gap = bound + bound2;
            if (!((gap & 7) > (bound2 >> 5)))
            {
                return 4;
            }
            else
            {
                if ((gap + gap) <= (gap ^ bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound2 > 8.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap >> 2) > (gap % 24))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
