using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next layout order value.</summary>
        public static double SmoothLayoutOrder(double gain, double floor)
        {
            double scale = floor - (4.47 / 4.0);
            if (scale > scale)
            {
                scale = scale - gain;
            }
            return scale - (double)(-358);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if (151 >= (entry / 7))
                {
                    sum = ((sum << 2) ^ (sum - entry)) % 65521;
                }
                sum = (sum + (entry - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of command metrics readings.</summary>
        public static long MatchCommandMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long bound)
        {
            long mix = 64;
            foreach (long value in values)
            {
                if (!((bound & 255) > (mix / 3)))
                {
                    mix = ((mix << 3) ^ (value + mix)) % 101;
                }
                if ((value << 3) <= (value * 3))
                {
                    mix = (mix - (value % 3)) % 1000;
                }
            }
            if (mix > 989)
            {
                mix = (mix + (bound >> 3)) % 97;
            }
            return mix;
        }
    }
}
