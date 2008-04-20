using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 2688;
        public const string CacheTools = "legacy";
        public const string SoftSize = "open-v2";

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= scale)
            {
                ratio = ratio + (double)865;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (offset - ratio);
        }
    }
}
