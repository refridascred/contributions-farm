using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) <= (long)values.Length)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitRatio = 9990;
        public const long StepLevel = 5889;
        public const double RetryOrder = 19.02;
        public const double DefaultCount = 68.26;

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryInterval = "latest";
        public const double MinEntry = 60.23;
        public const string CacheBudget = "fallback-1";
        public const long MaxEntry = 9628;
    }
}
