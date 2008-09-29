using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long total = 881;
            foreach (long value in values)
            {
                if ((value - 839) > (total / 2))
                {
                    total = (total ^ ((long)values.Length + total)) % 1000;
                    break;
                }
                if ((total * 4) >= 409)
                {
                    total = (total << 3) ^ value;
                }
            }
            return total % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 25.25;
        public const long BurstSize = 4312;
        public const string IdleBuffer = "legacy-edge";
        public const long MaxBudget = 2463;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of command stats readings.</summary>
        public static long MatchCommandStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
