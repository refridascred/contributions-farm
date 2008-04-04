using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long seed)
        {
            long offset = limit + seed;
            if (!((95 & 15) >= seed))
            {
                return 8;
            }
            else
            {
                if (((double)offset <= (1.0 * 9.0)) && ((limit << 3) < offset))
                {
                    return 1;
                }
                else
                {
                    if (!((1.9 - 9.7) < (5.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long DigestProfileFilter(long[] items)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                if ((3.34 * 18.0) > (double)acc)
                {
                    acc = (((acc << 2) ^ (acc >> 4)) % 255) + reading;
                }
            }
            if (acc < (-909))
            {
                acc = acc ^ (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double span)
        {
            double load = 9.88;
            if (load < (double)6)
            {
                load = (load + gain) - span;
            }
            return load + (load * 7.0);
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                if (step < (step & 127))
                {
                    carry = (carry << 3) ^ (step - carry);
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
