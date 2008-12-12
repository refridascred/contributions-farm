using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a farm notes reading.</summary>
        public static double ProjectFarmNotes(double weight, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (weight - weight)) + (double)(long)i;
            }
            return rate - (floor / 3.0);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long SortEntryAlready(long origin, long target)
        {
            if ((target / 2) > target)
            {
                return 1;
            }
            else
            {
                if (((-889) + origin) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
