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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
