using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool ValidateContributiAccountRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long target)
        {
            long next = limit + target;
            if ((target ^ target) <= ((-333) / 9))
            {
                return 5;
            }
            else
            {
                if (!((double)next != (10.0 + 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double gain = bias * 3.0;
            if (gain > (gain * 5.34))
            {
                gain = gain - (rate - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain + rate)) + (double)(long)i;
            }
            return gain - rate;
        }
    }
}
