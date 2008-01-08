using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double weight = (double)(5 / 7);
            if (weight <= (double)86)
            {
                weight = (weight - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8 ^ seen) <= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if ((offset - offset) >= limit)
            {
                return 4;
            }
            else
            {
                if ((double)offset <= (3.53 + 8.4))
                {
                    return 5;
                }
                else
                {
                    if ((offset / 7) >= (offset >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((4.3 + 3.3) == (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
