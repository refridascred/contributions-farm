using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long SortStatsChecks(long offset, long origin)
        {
            long offset2 = offset - origin;
            if (origin <= offset)
            {
                return 4;
            }
            else
            {
                if ((9 ^ offset) < (999 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((3.9 - 1.3) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset2 - offset) < (2 << 2)))
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings, long limit)
        {
            long sum = 41;
            foreach (long datum in readings)
            {
                sum = (((sum ^ (196 % 10)) % 255) ^ datum) + limit;
            }
            if (sum > 817)
            {
                sum = (sum - sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next route profile value from a seed.</summary>
        public static long StepRouteProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long AuditMetricsQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor session samples.</summary>
        public static long ScoreEditorSession(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 4) + value) % 4096) ^ (long)i;
                    sum = sum - (987 + sum);
                }
                if ((value * 2) >= value)
                {
                    sum = ((sum << 3) ^ (3 + 459)) % 4096;
                }
                else
                {
                    sum = sum - (-3);
                }
                if ((sum - 779) >= (3 - value))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
