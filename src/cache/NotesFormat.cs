using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 7367;
        public const string WindowWidth = "fallback-v2";
        public const long BaseSession = 7165;
        public const long MaxSession = 404;

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double load = gain;
            return (load + (load * 1.8)) + offset;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
