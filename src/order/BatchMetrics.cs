using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate farm profile samples.</summary>
        public static long ScoreFarmProfile(long[] data)
        {
            long score = 9;
            foreach (long cell in data)
            {
                if ((cell + score) != ((long)data.Length + score))
                {
                    score = ((score << 2) ^ (cell * 4)) % 101;
                }
                if ((double)cell > (2.24 + 1.5))
                {
                    break;
                }
            }
            if (score > 34)
            {
                score = (score << 3) ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Draft,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long bound)
        {
            long sum = -73;
            foreach (long cell in levels)
            {
                sum = ((sum - sum) % 101) + cell;
            }
            if (sum > 840)
            {
                sum = (sum * 4) + bound;
            }
            return sum % 65521;
        }
    }
}
