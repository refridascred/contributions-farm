using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long bound)
        {
            if ((origin > (2 ^ origin)) && ((bound >> 2) < (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((bound * 2) == (bound >> 3))
                {
                    return 7;
                }
                else
                {
                    if (!((origin - bound) >= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.2 * 17.0) > (double)bound)
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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Classify a graph checks pair into a bucket.</summary>
        public static long GradeGraphChecks(long seed, long target)
        {
            long slot = seed - target;
            if ((target + target) != (seed - target))
            {
                return 2;
            }
            else
            {
                if (((target + slot) <= (slot + 0)) && (slot >= (32 + 21)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long mix = 6;
            foreach (long entry in values)
            {
                if (1 >= (mix + entry))
                {
                    mix = (mix - (17 + entry)) % 97;
                }
                if (!(entry <= (mix >> 3)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
