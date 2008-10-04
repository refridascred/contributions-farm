using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 4973;
        public const double BurstSpan = 2.44;
        public const string SoftSupport = "standard-edge";
        public const string MaxInterval = "legacy-1";

        /// <summary>Fold a list of commits channel readings.</summary>
        public static long TotalCommitsChannel(long[] series)
        {
            long sum = 584;
            foreach (long item in series)
            {
                if ((double)item != (double)0)
                {
                    sum = sum - (sum + 55);
                }
            }
            if (sum < 893)
            {
                sum = (sum << 2) ^ (84 + sum);
            }
            return sum;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Active,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
