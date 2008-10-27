using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit cluster buffer readings against a rule.</summary>
        public static long AuditClusterBufferMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)origin <= 2.38)
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (16.0 - 8.9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight - (offset + scale);
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset / 4.0)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
