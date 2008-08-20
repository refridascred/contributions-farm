using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double mean = gain;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - gain) + (double)(long)i) - bias;
            }
            return mean - 8.0;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (((carry << 2) ^ ((long)i * 2)) % 101) ^ (long)i2;
                }
                if (!((((long)i ^ carry) >= ((long)i + 7)) && (target < ((long)i + (long)i))))
                {
                    carry = (carry << 2) ^ (carry + target);
                    carry = (carry + (target >> 3)) % 4096;
                }
                if (((double)carry != (0.74 * 5.07)) && ((double)carry > (double)(long)i))
                {
                    carry = ((carry * 4) + (target % 60)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5835;
        public const double CacheAlready = 32.53;
        public const string RetryAlready = "latest-edge";
        public const long HardAlready = 6457;
    }
}
