using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next cluster account value from a seed.</summary>
        public static long IterateClusterAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ carry) % 4096;
                if ((step << 3) >= (5 + 772))
                {
                    carry = carry - carry;
                }
                if (step >= (carry - carry))
                {
                    carry = (carry + step) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long CountGraphFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= ((long)levels.Length & 63))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell - limit))
                {
                    anchor = ((anchor * 3) + (29 ^ limit)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
