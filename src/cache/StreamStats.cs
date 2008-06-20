using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long CombineMetricsBuffer(long[] values, long origin)
        {
            long anchor = 813;
            foreach (long entry in values)
            {
                if (!((5.46 - 9.0) != (double)entry))
                {
                    anchor = ((anchor << 2) ^ origin) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + entry;
                }
            }
            if (anchor > 90)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a already counter reading by value.</summary>
        public static long LookupAlreadyCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((4.0 - 16.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (5 < (5 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (20.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit2 < (limit2 - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
