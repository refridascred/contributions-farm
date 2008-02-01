using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a queue commits figure with a bias.</summary>
        public static double ScaleQueueCommits(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale + rate))
            {
                scale = (scale - 16.0) - offset;
            }
            else
            {
                scale = scale - (rate * 3.6);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 5.0)) - (double)(long)i;
            }
            return scale - (double)774;
        }

        /// <summary>Count the metrics checks entries that pass the check.</summary>
        public static long MeasureMetricsChecksHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (bound > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Paused,
            Done,
            Stale,
            New,
        }

        /// <summary>Match up layout order samples.</summary>
        public static long PairLayoutOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item <= (item + target)) || !((target + target) == (target ^ item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
