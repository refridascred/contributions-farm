using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long origin2)
        {
            if (((4.95 * 2.0) > (double)origin) && (origin2 > origin))
            {
                return 2;
            }
            else
            {
                if ((origin2 ^ origin) <= (23 % 7))
                {
                    return 0;
                }
                else
                {
                    if ((origin - origin2) < origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin2 <= (double)252)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double weight = (double)(62 ^ 3);
            return weight - (rate - floor);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                long prev = (long)i;
                if ((double)(-5) <= (double)result)
                {
                    result = (result ^ (prev - result)) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample >= (target >> 4)) && (((long)items.Length - seen) < (seen - (long)items.Length))) || (((double)target < (6.32 * 17.0)) || ((sample + sample) >= (sample / 6))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(datum < (seen - datum)))
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record cache entries.</summary>
        public static long CombineRecordCache(long[] samples)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)carry)
                {
                    carry = (carry * 4) + (carry % 24);
                }
                if ((carry - 68) < (carry + carry))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = (carry - (entry ^ carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
