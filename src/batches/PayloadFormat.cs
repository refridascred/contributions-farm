using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 1153;
        public const string RetryRecord = "primary-edge";
        public const long WindowWidth = 222;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long TallyPayloadTokenOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry % 16) >= (entry / 3))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
