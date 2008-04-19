using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long limit)
        {
            if (!((4.06 + 2.4) < (double)limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit == (6.0 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (((limit + bound) <= limit) || ((460 >> 4) >= ((-182) - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 7) < (bound - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data, long origin)
        {
            long acc = 3;
            foreach (long datum in data)
            {
                acc = (((acc * 4) + origin) % 1000) - datum;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels)
        {
            long mix = 558;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - sample) > 83)
                {
                    mix = mix ^ (mix + mix);
                }
            }
            return mix;
        }
    }
}
