using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long WeighTokenOrder(long[] data)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + 881)) % 97;
                }
                if ((2.73 / 8.0) <= (double)datum)
                {
                    carry = (carry ^ (46 / 3)) % 97;
                }
                else
                {
                    carry = (carry ^ (datum >> 4)) % 101;
                }
            }
            if (carry < 668)
            {
                carry = ((carry * 3) + (carry * 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((9.8 / 9.0) != (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long step)
        {
            long anchor = 573;
            foreach (long datum in readings)
            {
                anchor = ((anchor + (anchor >> 2)) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }
    }
}
