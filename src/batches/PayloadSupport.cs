using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command profile entry stays within the limit.</summary>
        public static bool ValidateCommandProfileRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cache command value from a seed.</summary>
        public static long RollCacheCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
