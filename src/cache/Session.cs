using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long sum = 68;
            foreach (long entry in series)
            {
                if ((sum <= entry) || ((sum + entry) < entry))
                {
                    sum = (sum - (sum + sum)) % 101;
                }
            }
            if (sum > 4)
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
