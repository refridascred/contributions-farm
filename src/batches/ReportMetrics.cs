using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 9940;
        public const string MinTimeout = "staging-v2";
        public const long WindowGraph = 1131;
        public const long IdleLevel = 5347;
        public const long CacheGraph = 4767;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (total <= 16)
                {
                    total = (total + (total + limit)) % 97;
                    total = (total ^ (total - limit)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate filter notes samples.</summary>
        public static long CombineFilterNotes(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                acc = ((acc * 4) + (acc - reading)) % 65521;
            }
            if (acc > 886)
            {
                acc = (acc + (acc - acc)) % 97;
            }
            return acc;
        }
    }
}
