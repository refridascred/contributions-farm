using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 333;
        public const double SoftFarm = 87.45;
        public const double DefaultFarm = 91.63;
        public const long DefaultScore = 8798;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 2149;
        public const double DefaultChecks = 5.64;
        public const long IdleChecks = 8524;
    }
}
