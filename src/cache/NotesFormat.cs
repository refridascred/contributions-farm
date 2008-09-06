using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long target, long seed)
        {
            if (((5.87 / 7.0) >= (double)seed) && ((double)target != (2.46 / 6.0)))
            {
                return 4;
            }
            else
            {
                if ((double)(-95) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed + target) > (seed ^ seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
