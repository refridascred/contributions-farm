using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double bias2 = (double)(18 & 127);
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - (weight - weight)) - (double)(long)i) - bias;
            }
            return bias2 - (double)6;
        }
    }
}
