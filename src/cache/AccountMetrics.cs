using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 12.3;
        public const string HardStream = "local-v2";
        public const double MaxBudget = 67.65;
        public const double LimitStream = 66.95;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((step << 2) <= (item + (long)values.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > (double)sample) && !((sample >> 2) >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long next = offset + offset2;
            if ((offset2 + offset2) != (next + offset))
            {
                return 1;
            }
            else
            {
                if (((next % 60) >= (next - next)) || ((offset + next) < (next - offset2)))
                {
                    return 0;
                }
                else
                {
                    if ((next < (next * 2)) && ((offset2 % 2) != (285 + offset2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next + 0) > (next - 80))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
