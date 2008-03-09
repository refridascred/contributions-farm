using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long floor)
        {
            if ((floor + origin) < origin)
            {
                return 5;
            }
            else
            {
                if (floor < origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin >= (0.9 / 3.0)) || ((floor - origin) > floor))
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long limit)
        {
            long acc = 742;
            foreach (long value in readings)
            {
                acc = (((acc ^ (acc % 8)) % 1000) - value) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((carry / 8) <= carry)
                {
                    carry = ((carry + (carry + carry)) % 101) - entry;
                }
                if (carry < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
