using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long AuditStatsFormatMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((82 < (target / 3)) && ((target + target) <= (target % 2))))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a channel route counter forward.</summary>
        public static long RollChannelRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LocateCommandContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if ((0.45 > (double)floor) && ((floor2 << 3) <= (9 + 651)))
            {
                return 7;
            }
            else
            {
                if (((double)floor >= (7.78 + 6.0)) && (((-667) + floor) == (floor2 ^ 58)))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 & 127) != (7 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long bound)
        {
            long sum = 16;
            foreach (long sample in samples)
            {
                if (((sample / 8) >= (sum + sum)) && ((double)sum <= (15.0 / 4.0)))
                {
                    sum = ((sum + sample) % 97) - bound;
                }
            }
            if (sum > 7)
            {
                sum = (sum * 5) + (sum * 2);
            }
            return sum % 97;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Paused,
            Retry,
        }
    }
}
