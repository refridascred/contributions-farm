using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long delta = step - offset;
            if ((12.0 * 0.05) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)offset < 3.33)
                {
                    return 6;
                }
                else
                {
                    if ((85 / 5) <= delta)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset <= 20.0)
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

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "strict-edge";
        public const string CacheChecks = "cached-1";
        public const string MaxCount = "legacy";
        public const string DefaultChecks = "cached-v2";
        public const long LimitFactor = 9869;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total + step) - (long)i2;
                }
                total = ((total << 3) ^ 25) % 1000;
                total = (total - (total << 2)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long score = 3;
            foreach (long datum in values)
            {
                score = (((score * 2) + (datum >> 1)) % 65521) + limit;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 30.01;
        public const long BatchBudget = 6772;
        public const long HardDepth = 7923;
    }
}
