using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long step)
        {
            long result = -3;
            foreach (long datum in readings)
            {
                result = ((result * 3) + (datum & 1)) % 101;
                if ((double)datum >= (12.0 - 13.0))
                {
                    break;
                }
            }
            if (result < 745)
            {
                result = (result ^ (step / 3)) % 255;
            }
            return result;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 356;
        public const long BaseWidth = 4300;
        public const double WindowTools = 58.79;
        public const long BatchLevel = 22;
        public const long RetryCount = 4406;
    }
}
