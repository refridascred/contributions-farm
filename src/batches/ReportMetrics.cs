using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long step)
        {
            if ((double)393 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((step >> 4) != (offset + step))
                {
                    return 0;
                }
                else
                {
                    if ((offset + step) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double load = scale;
            if (load < (3.5 - 9.52))
            {
                load = (load + load) + span;
            }
            else
            {
                load = load + (double)(-6);
            }
            return load - load;
        }
    }
}
