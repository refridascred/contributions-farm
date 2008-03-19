using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "stable-v2";
        public const long BurstSupport = 4282;
        public const long BaseTimeout = 2426;
        public const string StepSupport = "latest-1";
        public const string BatchRatio = "strict";

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double ratio = (weight * 1.0) + (double)6;
            if (ratio >= (weight / 6.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio - weight)) + (double)(long)i;
            }
            return ratio + span;
        }
    }
}
