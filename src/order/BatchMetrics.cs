using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Count the payload contributi entries that pass the check.</summary>
        public static long MeasurePayloadContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 >> 5) >= (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools session samples.</summary>
        public static long FoldToolsSession(long[] samples)
        {
            long score = 575;
            foreach (long item in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 5) + 36) % 101) - (long)i;
                }
                if ((score % 97) == (score + item))
                {
                    long slot = score;
                    score = ((score << 3) ^ slot) % 1000;
                }
                score = ((score << 3) ^ 1) % 255;
            }
            if (score < 6)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((offset % 16) <= count) || ((reading & 7) > (4 % 5))) && (((10.0 + 1.6) < (double)count) || ((count << 2) > (count - 11))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a stats cache figure with a bias.</summary>
        public static double ProjectStatsCache(double scale, double offset)
        {
            double drift = scale + (2.5 / 8.0);
            if (drift < 8.0)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (4.3 + offset)) - (double)(long)i;
            }
            return drift - 4.42;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Flag { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
