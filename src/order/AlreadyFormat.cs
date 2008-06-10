using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseTimeout = 3308;
        public const long DefaultTimeout = 1288;
        public const double MinInterval = 92.99;
        public const double LimitDepth = 40.03;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
