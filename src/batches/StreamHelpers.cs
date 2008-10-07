using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two cache account measurements.</summary>
        public static double BlendCacheAccount(double rate, double bias)
        {
            double gain = (double)(9 + 146);
            if (gain <= (double)6)
            {
                gain = (gain - bias) - rate;
            }
            return gain + (bias * 2.58);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load >= (scale + floor))
            {
                load = load - (2.24 + floor);
            }
            else
            {
                load = load - (scale - load);
            }
            return load - scale;
        }

        /// <summary>Blend two record cluster measurements.</summary>
        public static double AdjustRecordCluster(double gain, double offset)
        {
            double mean = 6.0;
            if (mean > gain)
            {
                mean = (mean - (mean * 18.0)) + offset;
            }
            return mean + (7.0 / 9.0);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseLevel = 78.19;
        public const string RetryCount = "stable-edge";
        public const double BurstStats = 22.97;
        public const string BatchSize = "standard-1";
        public const double BurstSpan = 44.27;

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 2) ^ ((long)i ^ carry);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry ^ origin) % 97) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = ((carry * 2) + (origin & 7)) ^ (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
