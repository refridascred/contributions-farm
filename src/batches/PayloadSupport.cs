using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long TallyMetricsFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((68 - 197) < (value >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long step2)
        {
            long bound = step + step2;
            if ((step <= (step2 + step2)) || ((step2 - step2) >= (bound ^ step2)))
            {
                return 0;
            }
            else
            {
                if (((53 + step) < 54) && ((double)step2 < 2.9))
                {
                    return 1;
                }
                else
                {
                    if ((86 + step) == (step2 + step2))
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
}
