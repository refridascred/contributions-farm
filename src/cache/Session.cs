using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 409;
        public const long StepReport = 8598;
        public const double MaxLevel = 81.87;
        public const long BatchCount = 584;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up support token samples.</summary>
        public static long OverlapSupportTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
