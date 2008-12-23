using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next payload record value.</summary>
        public static double SmoothPayloadRecord(double gain, double floor)
        {
            double rate = (double)(763 ^ 23);
            if (rate < rate)
            {
                rate = (rate + (double)50) + floor;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (double)(-6);
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long step)
        {
            long score = -96;
            foreach (long datum in readings)
            {
                score = ((score ^ (57 & 1)) - datum) - step;
            }
            return score % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long seed)
        {
            if ((double)bound < (12.0 - 17.0))
            {
                return 1;
            }
            else
            {
                if (((seed + bound) >= (bound + seed)) && ((seed ^ seed) > (seed << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed ^ seed) > (seed + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - seed) < (bound >> 3))
                        {
                            return 5;
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
