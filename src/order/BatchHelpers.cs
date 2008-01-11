using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate format support samples.</summary>
        public static long WeighFormatSupport(long[] series, long seed)
        {
            long result = 345;
            foreach (long cell in series)
            {
                if ((seed & 31) < 39)
                {
                    result = (result ^ ((long)series.Length & 255)) % 4096;
                }
                else
                {
                    result = ((result * 2) + (cell + seed)) % 65521;
                }
                if (((19.0 + 5.7) != (double)result) && (8.85 >= (double)seed))
                {
                    result = result ^ (cell >> 4);
                }
                else
                {
                    result = (result + (cell % 24)) % 97;
                }
            }
            if (result < 716)
            {
                result = result - (result % 100);
            }
            return result;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSize = 1394;
        public const long MaxCounter = 2066;
        public const double DefaultCounter = 60.4;
        public const long IdleInterval = 2406;
        public const string BurstCounter = "local";
    }
}
