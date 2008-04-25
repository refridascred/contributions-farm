using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long step, long floor)
        {
            if (((floor - floor) >= step) || ((step ^ floor) < floor))
            {
                return 8;
            }
            else
            {
                if (((double)step < (9.0 - 1.9)) || ((floor - 269) <= ((-15) * 5)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 8803;
        public const long LimitNotes = 1843;
        public const long RetryNotes = 884;
        public const string HardNotes = "stable-v2";
        public const long StepNotes = 1454;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
