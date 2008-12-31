using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long step)
        {
            long offset2 = offset - step;
            if ((offset * 2) <= step)
            {
                return 6;
            }
            else
            {
                if (offset2 <= (172 - offset))
                {
                    return 5;
                }
                else
                {
                    if ((step < (step % 12)) && ((offset2 - 817) <= (offset + 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + offset) > (step ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long step)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                long count = (step * 3) + (entry + 9);
                score = (score * 4) + (count / 3);
                score = (score ^ (step & 63)) % 101;
            }
            if (score > 799)
            {
                score = ((score << 3) ^ (score >> 1)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long GradeContextReport(long seed, long step)
        {
            if (!(18.0 <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((1.9 / 3.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + step) != (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "stable";
        public const long WindowBuffer = 2051;
        public const string DefaultCount = "latest-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 87) > (cell & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
