using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 67;
            foreach (long value in values)
            {
                if (value <= (value ^ state))
                {
                    state = state ^ (state << 3);
                    state = (state ^ (value >> 2)) % 4096;
                    break;
                }
                state = (state - value) % 101;
                if ((state < value) || ((value - value) > value))
                {
                    state = ((state << 2) ^ value) % 255;
                }
                if (((-2) - state) >= 0)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long SortStatsCommand(long target, long bound)
        {
            if ((7.27 > (double)bound) || ((-6) < (bound - 9)))
            {
                return 3;
            }
            else
            {
                if (bound >= (85 >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) <= (9 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) > target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
