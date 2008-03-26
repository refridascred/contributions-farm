using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long OverlapPayloadClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Draft,
            Stale,
            Active,
            New,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double scale2 = scale * 18.0;
            if (scale2 <= (scale2 / 7.0))
            {
                scale2 = scale2 - (scale - 0.3);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + 19.0) - (double)(long)i;
            }
            return scale2 - (scale2 - bias);
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double weight = (double)(9 / 7);
            return ((weight - weight) + rate) + bias;
        }

        /// <summary>Iterate the report notes series from a seed.</summary>
        public static long IterateReportNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
