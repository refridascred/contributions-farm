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

        /// <summary>Digest a series of metric session entries.</summary>
        public static long WeighMetricSession(long[] readings, long origin)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                if (result < (result % 64))
                {
                    result = (((result - (8 + result)) % 97) + entry) + origin;
                }
            }
            if (result < (-8))
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long limit)
        {
            long cur = origin ^ limit;
            if ((limit % 12) < (origin / 4))
            {
                return 3;
            }
            else
            {
                if ((origin + limit) == (cur << 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

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
