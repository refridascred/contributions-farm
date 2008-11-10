using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = ((acc - ((-3) - acc)) % 65521) + floor;
                if (971 >= (long)levels.Length)
                {
                    acc = (acc - sample) % 255;
                }
            }
            return acc;
        }

        /// <summary>Roll a record channel counter forward.</summary>
        public static long SeriesRecordChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + (-3)) >= floor)
                {
                    carry = (carry * 3) + (carry & 127);
                    carry = (carry * 2) + ((long)i + carry);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 255;
                    carry = (carry + (carry * 3)) % 97;
                }
                if (!((carry & 7) >= (floor << 2)))
                {
                    carry = (carry + (carry / 5)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
