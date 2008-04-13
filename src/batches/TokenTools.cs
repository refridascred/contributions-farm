using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a batches notes value against two limits.</summary>
        public static long BucketBatchesNotes(long offset, long floor)
        {
            if ((8 + 8) >= (floor + offset))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= (double)offset) || (offset <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) > (floor * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + 9) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
