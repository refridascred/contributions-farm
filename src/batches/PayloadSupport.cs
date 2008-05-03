using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long step)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                carry = (((carry * 2) + (7 * 4)) % 255) ^ reading;
            }
            if (carry > 6)
            {
                carry = carry ^ (step << 2);
            }
            return carry % 65521;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            long prev = limit - origin;
            if (((prev & 1) > prev) && ((double)origin == (15.0 + 4.83)))
            {
                return 4;
            }
            else
            {
                if ((7.6 * 7.5) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((prev ^ origin) >= prev)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev < (3.82 + 9.7)) && (limit < (94 + prev)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
