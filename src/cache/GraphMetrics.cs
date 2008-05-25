using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchCount = "local-v2";
        public const double RetrySession = 5.17;
        public const long DefaultRatio = 8571;
        public const double StepSession = 21.97;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long limit)
        {
            long diff = offset - limit;
            if ((double)diff > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((1.62 - 9.7) != (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((2 % 64) >= (limit / 3))
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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
