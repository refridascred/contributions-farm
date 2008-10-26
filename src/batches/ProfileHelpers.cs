using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count session stream pairs that satisfy a relation.</summary>
        public static long CompareSessionStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step < sum) && ((double)(long)i > (8.0 - 5.32)))
                {
                    break;
                }
                if ((((long)i / 3) == ((long)i / 7)) || ((sum / 4) == (step + step)))
                {
                    sum = ((sum << 3) ^ step) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 3);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (double)777)
            {
                gain = (gain - 20.0) - ratio;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long bound)
        {
            long carry = -52;
            foreach (long value in readings)
            {
                if (!(3 <= (bound - (-8))))
                {
                    carry = (carry * 3) + (bound + value);
                }
            }
            return carry;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
