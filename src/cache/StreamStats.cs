using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardSpan = 13.9;
        public const long DefaultStream = 9700;
        public const double BaseStream = 10.37;
        public const long BurstTimeout = 3371;
        public const string StepStream = "latest-edge";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((15.0 + 17.0) > (double)floor)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
