using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (9.7 <= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
