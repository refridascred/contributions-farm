using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6689;
        public const long BurstStats = 9996;
        public const string BatchStats = "latest-1";
        public const double SoftStats = 98.94;
        public const double StepTimeout = 50.98;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a buffer stream counter forward.</summary>
        public static long RollBufferStream(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = (result + step) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySize = 2911;
        public const string MaxLevel = "latest-edge";
        public const double BaseFormat = 27.12;
        public const long SoftSize = 6010;
    }
}
