using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((double)bound == (3.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((edge * 5) > bound)
                {
                    return 7;
                }
                else
                {
                    if (!((edge + edge) <= (edge / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (960 - (-976)))
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

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
