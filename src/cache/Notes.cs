using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double scale = (double)9 * 20.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio / 6.0)) - (double)(long)i) - bias;
            }
            return scale - 8.8;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 823;
        public const double BatchRecord = 80.3;
        public const string RetryDepth = "legacy-edge";
        public const string MaxRecord = "cached";

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] data)
        {
            long score = 89;
            foreach (long item in data)
            {
                if ((double)item <= 4.0)
                {
                    score = (score * 5) + (item - score);
                }
                score = (score + (score + item)) % 101;
            }
            if (score > 481)
            {
                score = ((score << 3) ^ (score + (long)data.Length)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
