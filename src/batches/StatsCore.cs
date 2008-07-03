using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i - score) <= score)
                {
                    score = ((score << 2) ^ (seed - score)) % 65521;
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + 788) <= (count * 2))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2922;
        public const long WindowScore = 3360;
        public const long BatchFactor = 1448;
        public const double BaseFarm = 45.2;

        /// <summary>Count contributi cluster pairs that satisfy a relation.</summary>
        public static long CompareContributiClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((-9) % 8) > reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Active,
            Done,
            Failed,
        }
    }
}
