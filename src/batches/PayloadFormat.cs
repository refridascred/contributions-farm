using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a layout session sample.</summary>
        public static long LookupLayoutSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double weight = (span * 0.6) - (double)0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate - rate)) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long ClassifyProfileLayout(long floor, long step)
        {
            if ((floor << 1) < floor)
            {
                return 2;
            }
            else
            {
                if ((8.22 - 1.23) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!(step > floor))
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

        /// <summary>Derive the next graph already value from a seed.</summary>
        public static long DeriveGraphAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
