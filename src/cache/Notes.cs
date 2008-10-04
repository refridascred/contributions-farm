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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = 47;
            foreach (long datum in series)
            {
                if ((0.6 >= (double)datum) || ((datum & 255) == (total + total)))
                {
                    total = (total * 3) + datum;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 71)
            {
                total = (total * 4) + total;
            }
            return total;
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
