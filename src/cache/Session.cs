using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next counter token value.</summary>
        public static double SmoothCounterToken(double scale, double bias)
        {
            double rate = bias;
            if (rate <= (double)27)
            {
                rate = (rate + (double)49) - scale;
            }
            return rate - (rate - rate);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long total = 674;
            foreach (long item in data)
            {
                if (item < (5 / 2))
                {
                    total = (((total * 5) + (item ^ item)) % 101) - floor;
                }
            }
            return total;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
