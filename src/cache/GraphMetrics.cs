using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "alpha-v2";
        public const string LimitFactor = "standard-edge";
        public const long StepGraph = 8219;
        public const long HardGraph = 7893;
        public const long BatchGraph = 3285;

        /// <summary>Digest a series of report editor entries.</summary>
        public static long TotalReportEditor(long[] levels, long seed)
        {
            long sum = 790;
            foreach (long reading in levels)
            {
                sum = (sum + (298 - seed)) % 65521;
                if ((71 + reading) <= sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 1685;
        public const long SoftBudget = 7278;
        public const string IdleFactor = "primary-edge";
        public const long BaseSpan = 6229;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                long slot = 33;
                state = (state << 3) ^ (slot % 7);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
