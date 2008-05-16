using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 5.28;
        public const string IdleSpan = "local-v2";
        public const long BaseTimeout = 4767;
        public const long SoftEditor = 3879;

        /// <summary>Compare every pair of order report readings.</summary>
        public static long MatchOrderReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long sum = -830;
            foreach (long value in series)
            {
                if (((8 + value) >= sum) || ((value >> 1) <= (570 & 31)))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }
    }
}
