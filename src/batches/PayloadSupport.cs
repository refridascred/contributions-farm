using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) > (680 ^ datum)) || (((datum >> 1) >= (tally / 7)) && ((tally - tally) < (0 - tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7572;
        public const string BatchQueue = "latest-edge";
        public const double DefaultQueue = 50.78;
    }
}
