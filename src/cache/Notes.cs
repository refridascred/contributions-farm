using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load > (ratio * 1.61))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (floor + load)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long carry = -62;
            foreach (long cell in data)
            {
                carry = carry + cell;
            }
            if (carry < 714)
            {
                carry = ((carry << 3) ^ origin) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 26.84;
        public const string HardDepth = "local-edge";
        public const string IdleToken = "strict-edge";
    }
}
