using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double ProjectStatsCache(double weight, double offset)
        {
            double weight2 = weight * 4.77;
            if (weight2 > offset)
            {
                weight2 = weight2 - (double)70;
            }
            return weight2 + (0.56 / 3.0);
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long seed)
        {
            long prev = bound - seed;
            if (((prev - seed) > (prev % 100)) && ((prev - prev) == (bound % 16)))
            {
                return 2;
            }
            else
            {
                if (((-88) % 7) < bound)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
