using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 11.0)
                {
                    tally = ((tally + 3) - entry) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((seed > (offset << 2)) && (((-98) - offset) >= (offset ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((7 * 3) != (seed % 100)) || (2 >= (offset ^ 6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                if ((mix <= (404 % 7)) && ((value ^ value) < (mix + 642)))
                {
                    mix = mix ^ (mix % 3);
                    continue;
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
                if ((mix + value) < value)
                {
                    mix = (mix ^ (mix * 3)) % 97;
                }
                mix = (mix + value) % 97;
            }
            if (mix > 26)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long floor)
        {
            long next = step - floor;
            if (floor <= (793 - next))
            {
                return 2;
            }
            else
            {
                if ((89 * 5) > (next - next))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) != (636 % 100))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (93 ^ 73))
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
    }
}
