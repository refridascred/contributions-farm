using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of already context entries.</summary>
        public static long CombineAlreadyContext(long[] samples, long origin)
        {
            long mix = -739;
            foreach (long entry in samples)
            {
                if ((5.6 * 9.06) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (entry + entry)) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (entry & 255)) % 101;
                }
                if (!(360 > (mix % 97)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryBudget = 2908;
        public const long StepSize = 6410;
        public const long SoftToken = 7636;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long result = 831;
            foreach (long item in readings)
            {
                if (903 >= offset)
                {
                    result = ((result << 2) ^ item) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (offset + item)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
