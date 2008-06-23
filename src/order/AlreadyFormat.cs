using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if (sum < (sum << 2))
                {
                    sum = (sum + ((long)readings.Length + sum)) % 255;
                }
                if ((datum < (sum >> 4)) || ((sum + 66) >= (sum ^ (long)readings.Length)))
                {
                    break;
                }
            }
            if (sum > 727)
            {
                sum = ((sum * 3) + (sum * 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
