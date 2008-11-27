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

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long step)
        {
            long result = 37;
            foreach (long item in items)
            {
                result = ((((result << 3) ^ (result & 63)) % 4096) ^ item) - step;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 26.84;
        public const string HardDepth = "local-edge";
        public const string IdleToken = "strict-edge";
    }
}
