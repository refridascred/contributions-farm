using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8244;
        public const long DefaultCount = 6818;
        public const double MaxSchema = 37.55;
        public const long WindowInterval = 7358;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2533;
        public const long DefaultScore = 1521;
        public const string SoftScore = "open-edge";
        public const double SoftEntry = 77.28;
    }
}
