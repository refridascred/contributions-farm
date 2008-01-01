using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long floor)
        {
            long anchor = 48;
            foreach (long value in readings)
            {
                anchor = (((anchor * 4) + 162) - value) - floor;
            }
            return anchor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstInterval = "primary";
        public const double SoftGraph = 27.09;
        public const long LimitScore = 1361;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items)
        {
            long mix = 63;
            foreach (long value in items)
            {
                if ((2.0 / 3.0) < (6.0 - 2.62))
                {
                    mix = (mix * 4) + value;
                }
                if (mix >= (value >> 4))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
