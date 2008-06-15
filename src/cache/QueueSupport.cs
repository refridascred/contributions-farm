using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            if (((-6) % 16) <= (limit - bound))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) >= limit)
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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double load = (rate * 5.9) - span;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load + rate)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
