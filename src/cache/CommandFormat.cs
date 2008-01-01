using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window notes readings against a bound.</summary>
        public static bool GuardWindowNotesBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of commits editor readings.</summary>
        public static long TallyCommitsEditor(long[] items, long origin)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                if (!((origin * 3) >= (anchor + anchor)))
                {
                    anchor = (anchor + (anchor >> 1)) - entry;
                }
                anchor = anchor + ((-499) + 6);
            }
            if (anchor > 325)
            {
                anchor = ((anchor * 3) + anchor) % 255;
            }
            return anchor;
        }
    }
}
