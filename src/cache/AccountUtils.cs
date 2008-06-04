using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 8543;
        public const long MinCount = 267;
        public const long DefaultChecks = 4211;
        public const double HardChecks = 92.0;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long acc = -8;
            foreach (long reading in samples)
            {
                acc = acc ^ (acc % 8);
                if ((reading + reading) == (reading - reading))
                {
                    acc = (acc ^ (reading % 3)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
