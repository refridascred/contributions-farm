using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2874;
        public const long BaseSession = 3006;
        public const long MaxInterval = 5469;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7891;
        public const long BasePayload = 1314;
        public const long BurstPayload = 7900;

        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long MatchEditorNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 6243;
        public const long WindowBatches = 1301;
        public const string MaxTimeout = "standard-edge";

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
