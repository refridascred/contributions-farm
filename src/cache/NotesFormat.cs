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

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 91.99;
        public const long BurstGraph = 2756;
        public const long IdleLevel = 4755;
        public const string BatchGraph = "alpha-edge";
        public const long MinRatio = 4171;
    }
}
