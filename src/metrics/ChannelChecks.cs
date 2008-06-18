using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double rate, double offset)
        {
            double drift = (double)(696 >> 1);
            return ((drift + 3.96) + rate) + offset;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double scale = (0.2 / 5.0) + offset;
            if (scale <= (offset / 4.0))
            {
                scale = scale - (weight * 7.86);
            }
            return scale + (weight / 6.0);
        }

        /// <summary>Scale a context commits figure with a bias.</summary>
        public static double BlendContextCommits(double gain, double bias)
        {
            double load = (double)(4 / 5);
            if (load <= (bias / 7.0))
            {
                load = load - bias;
            }
            return load - gain;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits != (4.95 / 8.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long IterateGraphCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (91 & 15)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank checks editor input into a small class.</summary>
        public static long SortChecksEditor(long target, long seed)
        {
            long next = target ^ seed;
            if (((double)next > (8.71 - 6.0)) || ((target & 31) != (next >> 5)))
            {
                return 8;
            }
            else
            {
                if ((target + next) != (next / 5))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
