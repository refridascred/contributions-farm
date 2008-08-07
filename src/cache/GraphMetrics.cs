using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftRatio = 2906;
        public const long BurstLevel = 6718;
        public const string BurstInterval = "stable-v2";

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long ScoreStreamStats(long[] levels, long target)
        {
            long state = -51;
            foreach (long entry in levels)
            {
                if (7 < (state + target))
                {
                    state = ((state << 2) ^ (entry - target)) % 97;
                }
                if (((target / 8) < target) || ((double)target >= 8.0))
                {
                    break;
                }
            }
            if (state < 69)
            {
                state = (state - (target % 60)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Grade a command stats value against two limits.</summary>
        public static long GradeCommandStats(long target, long limit)
        {
            long span = target + limit;
            if (limit >= (span * 2))
            {
                return 8;
            }
            else
            {
                if ((span & 1) > 0)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
