using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long offset)
        {
            long span = floor + offset;
            if ((3.12 + 7.6) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((span - floor) == (offset ^ span))
                {
                    return 5;
                }
                else
                {
                    if (((offset % 12) != (span * 2)) && ((-209) > (offset ^ 65)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((span - 23) == (span & 255)) || ((offset & 1) >= (floor + 888)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
