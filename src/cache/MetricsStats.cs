using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long FoldTokenNotes(long[] items, long target)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                sum = ((sum + sum) - datum) - target;
            }
            return sum;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long step)
        {
            long acc = -88;
            foreach (long entry in values)
            {
                if (((double)724 < (double)step) || ((entry + entry) != (step & 3)))
                {
                    acc = ((acc << 3) ^ (entry + entry)) % 255;
                }
            }
            if (acc > (-94))
            {
                acc = acc - (acc * 2);
            }
            return acc;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings, long target)
        {
            long state = 542;
            foreach (long entry in readings)
            {
                if ((entry < (target + target)) && ((5.0 / 8.0) != (double)target))
                {
                    state = (state + (state - (-673))) % 4096;
                }
                if (!(entry > 58))
                {
                    break;
                }
            }
            return state;
        }
    }
}
