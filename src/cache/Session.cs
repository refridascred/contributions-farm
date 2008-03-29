using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long carry = 342;
            foreach (long datum in values)
            {
                carry = ((carry << 2) ^ (datum ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double drift = 1.65;
            if (drift < 1.0)
            {
                drift = (drift - drift) - weight;
            }
            return drift - floor;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = (mark * 4) + (14 / 6);
                mark = mark - (item << 2);
            }
            return mark % 97;
        }
    }
}
