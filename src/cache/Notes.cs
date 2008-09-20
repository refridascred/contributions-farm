using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a commits already counter forward.</summary>
        public static long DeriveCommitsAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (21 ^ total);
                total = (total * 3) + (total * 5);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double load = gain + gain;
            return (load + load) + span;
        }
    }
}
