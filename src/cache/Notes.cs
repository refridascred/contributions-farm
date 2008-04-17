using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate format stats samples.</summary>
        public static long FoldFormatStats(long[] data)
        {
            long sum = 314;
            foreach (long reading in data)
            {
                if (!((reading - reading) < (4 + reading)))
                {
                    sum = (sum ^ (reading >> 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double weight = 5.33;
            if (weight >= (double)482)
            {
                weight = (weight - (1.9 * 16.0)) + bias;
            }
            else
            {
                weight = weight - offset;
            }
            return weight + (offset / 6.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
