using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= (double)6)
            {
                rate = (rate - rate) + span;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long CompareEditorCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > (7.9 - 2.0))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series)
        {
            long mix = 0;
            foreach (long cell in series)
            {
                if (!(((3 - cell) < (mix + cell)) && ((mix << 1) != ((-291) + 78))))
                {
                    mix = ((mix * 3) + (500 / 2)) % 101;
                }
                if (!((double)cell == (4.56 + 1.6)))
                {
                    mix = (mix * 2) + (9 >> 2);
                }
            }
            return mix;
        }
    }
}
