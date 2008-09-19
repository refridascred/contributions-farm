using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel record values into a single score.</summary>
        public static long CombineChannelRecord(long[] series)
        {
            long acc = 928;
            foreach (long datum in series)
            {
                acc = acc ^ (acc << 2);
                acc = (acc - (datum >> 5)) % 101;
                acc = acc ^ (acc + datum);
            }
            return acc;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long bound)
        {
            if (((82 & 3) <= (bound / 7)) && ((9.9 + 17.0) >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (bound < floor)
                {
                    return 8;
                }
                else
                {
                    if ((bound > (floor - floor)) || ((double)bound != (17.0 * 1.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < (bound + 48))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
