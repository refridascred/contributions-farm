using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryWidth = 25.22;
        public const long DefaultEditor = 5739;
        public const string MaxDepth = "primary-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftSpan = 3967;

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data, long target)
        {
            long acc = -852;
            foreach (long reading in data)
            {
                if (((4 ^ acc) <= reading) || ((reading + target) == (reading % 60)))
                {
                    acc = (acc ^ (reading ^ reading)) % 97;
                    acc = (acc - 3) % 97;
                }
                acc = ((acc << 3) ^ (acc << 3)) % 1000;
            }
            if (acc < (-2))
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (offset / 5.0))
            {
                gain2 = gain2 + (offset / 6.0);
            }
            else
            {
                gain2 = gain2 - (gain / 3.0);
            }
            return gain2 + (gain2 * 19.0);
        }
    }
}
