using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long step)
        {
            long lane = floor - step;
            if (((step + lane) < step) && ((86 + 19) > (274 - step)))
            {
                return 1;
            }
            else
            {
                if ((step / 5) >= (floor + lane))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Locate a session route reading by value.</summary>
        public static long SeekSessionRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
