using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total - (total & 63)) ^ (long)i2;
                }
                if ((8.9 + 14.0) < (double)step)
                {
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ step) % 65521;
                }
                total = total ^ total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryScore = "latest-edge";
        public const long StepWidth = 4757;
        public const long HardSize = 7562;
        public const long RetrySupport = 1784;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitScore = "local-v2";
        public const string StepFactor = "local-1";
        public const double BurstAlready = 42.24;
        public const long MinAlready = 2283;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry - (value ^ carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
