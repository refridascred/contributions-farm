using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleScore = 9485;
        public const long MaxStats = 6444;
        public const string StepTimeout = "legacy-edge";

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every cluster support entry stays within the limit.</summary>
        public static bool VerifyClusterSupportLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "alpha";
        public const long StepNotes = 77;
        public const double RetryLevel = 98.16;
        public const long WindowNotes = 8170;
        public const double BaseSize = 98.0;
    }
}
