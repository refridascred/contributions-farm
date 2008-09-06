using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit already counter readings against a rule.</summary>
        public static long CountAlreadyCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry > (4.0 / 2.0)) || !((4 ^ matches) >= (long)series.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "strict-edge";
        public const long BatchFactor = 2533;
        public const long BatchRecord = 2013;
        public const double IdleLevel = 46.43;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data)
        {
            long score = 39;
            foreach (long reading in data)
            {
                if ((759 / 3) >= reading)
                {
                    score = (score ^ (300 + reading)) % 65521;
                }
                else
                {
                    score = (score ^ (reading / 7)) % 101;
                }
            }
            return score;
        }
    }
}
