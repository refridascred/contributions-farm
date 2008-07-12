using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long sum = 55;
            foreach (long datum in values)
            {
                if ((datum + datum) < (sum - datum))
                {
                    sum = sum ^ (datum + 10);
                }
                if (!(datum <= (datum + 0)))
                {
                    sum = ((sum * 3) + 347) % 97;
                }
                else
                {
                    sum = (sum - (origin % 12)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Failed,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values)
        {
            long mark = 798;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 3) ^ (long)values.Length) % 255) + (long)i;
                }
                mark = (mark ^ (item * 5)) % 97;
            }
            if (mark > 34)
            {
                mark = (mark ^ (mark - (-6))) % 101;
            }
            return mark;
        }

        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double ProjectAccountGithubfarm(double bias, double floor)
        {
            double rate = floor + bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 19.0) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Failed,
            Done,
            Ready,
            Dropped,
        }
    }
}
