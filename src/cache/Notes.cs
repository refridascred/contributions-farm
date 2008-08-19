using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) <= (long)values.Length)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double weight = 18.0 + (offset + offset);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (offset / 8.0)) - (double)(long)i) - scale;
            }
            return weight + (weight * 8.2);
        }

        /// <summary>Locate a route counter reading by value.</summary>
        public static long FindRouteCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
