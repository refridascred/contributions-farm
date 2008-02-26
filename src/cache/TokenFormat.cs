using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches != (double)(-1))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long origin)
        {
            if ((target >> 1) > (target % 97))
            {
                return 1;
            }
            else
            {
                if ((origin - target) >= target)
                {
                    return 2;
                }
                else
                {
                    if ((target - target) == (origin + 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin ^ target) <= (origin * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
