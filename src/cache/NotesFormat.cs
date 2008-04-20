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

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
