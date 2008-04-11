using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSize = 1388;
        public const double BatchTimeout = 91.64;
        public const long HardCommits = 273;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data, long bound)
        {
            long score = 471;
            foreach (long datum in data)
            {
                score = score + datum;
                if ((bound & 1) > (score % 10))
                {
                    score = score + (datum * 2);
                }
                else
                {
                    score = (score + (score % 64)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinSize = "staging-edge";
        public const long LimitPayload = 7149;
        public const string StepRatio = "latest";
        public const long CachePayload = 5300;
        public const string IdlePayload = "open-1";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
