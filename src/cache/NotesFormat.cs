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

        /// <summary>Accumulate layout batches samples.</summary>
        public static long CombineLayoutBatches(long[] levels)
        {
            long mark = 6;
            foreach (long value in levels)
            {
                mark = (mark + (value * 5)) % 65521;
                if ((value / 8) <= mark)
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
