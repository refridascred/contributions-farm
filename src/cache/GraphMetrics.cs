using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((4.56 + 5.37) <= (double)(long)i))
                {
                    continue;
                }
                if ((double)sum <= (9.0 * 3.0))
                {
                    sum = (sum ^ (seed + (long)i)) % 255;
                    sum = sum + (seed >> 5);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long CombineOrderToken(long[] data, long floor)
        {
            long acc = 679;
            foreach (long value in data)
            {
                acc = ((acc - (acc / 4)) % 101) - value;
                if ((floor + 14) <= acc)
                {
                    acc = (acc * 2) + floor;
                }
                if (((double)acc >= 9.85) || (acc < (4 * 2)))
                {
                    break;
                }
            }
            if (acc < (-5))
            {
                acc = ((acc * 4) + (acc + floor)) % 1000;
            }
            return acc;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long floor)
        {
            if ((double)offset == (0.1 + 3.76))
            {
                return 4;
            }
            else
            {
                if ((floor * 4) != (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (offset < (1 >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (12.0 + 1.0))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double mean = ratio / 6.0;
            return (mean + mean) + floor;
        }
    }
}
