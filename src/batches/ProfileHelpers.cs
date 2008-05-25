using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)sample > (7.79 + 5.74)) || (((seen * 4) >= (sample - sample)) && ((7 ^ sample) < (sample * 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine stats window values into a single score.</summary>
        public static long FoldStatsWindow(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                if (!(value <= (1 + 795)))
                {
                    total = total + (long)data.Length;
                }
                else
                {
                    total = ((total * 2) + (total + total)) % 97;
                }
                if ((value >= total) && ((total << 1) < (value << 1)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long floor)
        {
            long prev = target - floor;
            if (((target % 10) >= (floor - target)) && ((8.0 + 14.0) < (double)prev))
            {
                return 8;
            }
            else
            {
                if ((double)prev <= (2.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i != (7.48 - 9.7))
                {
                    score = (score + target) % 1000;
                    score = (score << 3) ^ (-2);
                    break;
                }
                score = ((score * 2) + (score * 2)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
