using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long target)
        {
            if (!((offset + target) == (31 - target)))
            {
                return 6;
            }
            else
            {
                if (((offset % 64) != (offset + target)) || ((offset % 10) != (offset % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((offset % 16) >= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - target) >= 54)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Done,
            Queued,
            Ready,
            Synced,
        }
    }
}
