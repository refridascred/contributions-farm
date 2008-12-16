using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine support profile values into a single score.</summary>
        public static long DigestSupportProfile(long[] data)
        {
            long state = 619;
            foreach (long cell in data)
            {
                state = (state ^ (cell / 2)) % 97;
                state = state ^ 970;
            }
            if (state < 465)
            {
                state = (state + (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record graph value against two limits.</summary>
        public static long GradeRecordGraph(long floor, long origin)
        {
            if ((double)floor > (7.1 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((origin >> 2) > (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if (((origin + floor) < (origin + origin)) || ((double)floor <= 8.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin <= (1.5 / 7.0)) || (294 <= (floor << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
