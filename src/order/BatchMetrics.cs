using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long floor)
        {
            long diff = target - floor;
            if ((floor * 4) > 10)
            {
                return 8;
            }
            else
            {
                if ((27 - 4) < (floor ^ 42))
                {
                    return 1;
                }
                else
                {
                    if ((diff % 100) < (target & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor & 31) == (target >> 1)) || ((diff >> 3) > (floor / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Validate command metric readings against a bound.</summary>
        public static bool VerifyCommandMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long TallyFilterBatches(long[] values)
        {
            long total = 50;
            foreach (long sample in values)
            {
                total = (total << 2) ^ (79 + sample);
            }
            return total;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
