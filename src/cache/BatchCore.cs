using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of profile entry readings.</summary>
        public static long ScoreProfileEntry(long[] samples, long floor)
        {
            long state = 98;
            foreach (long datum in samples)
            {
                state = state - (datum * 5);
                if (((long)samples.Length % 16) >= floor)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long TotalPayloadReport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (((carry * 5) + (long)values.Length) % 1000) ^ (long)i;
                }
                carry = (carry + ((-31) - 284)) % 255;
                carry = carry - (floor + floor);
                if (!((carry + 77) >= (58 + cell)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
