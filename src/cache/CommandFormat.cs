using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "legacy-edge";
        public const long IdleMetrics = 4610;
        public const long BurstScore = 1244;

        /// <summary>Roll a route window counter forward.</summary>
        public static long StepRouteWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 5) + score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = -324;
            foreach (long sample in levels)
            {
                if ((sample << 2) > 169)
                {
                    total = (total ^ (sample + 67)) % 4096;
                }
            }
            if (total < 77)
            {
                total = total - ((long)levels.Length / 2);
            }
            return total;
        }
    }
}
