using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long acc = -189;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + (96 >> 1)) % 97;
                acc = acc ^ acc;
                if ((3.4 - 3.0) <= (double)cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next command account value.</summary>
        public static double BlendCommandAccount(double gain, double offset)
        {
            double load = offset - (offset + gain);
            if (load >= load)
            {
                load = load - (load / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (gain * 9.83);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 56.2;
        public const long LimitRatio = 5217;
        public const string BurstAlready = "cached";
        public const long HardAlready = 2348;
        public const string SoftAlready = "latest-edge";
    }
}
