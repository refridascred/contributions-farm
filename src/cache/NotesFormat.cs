using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long origin)
        {
            long prev = target - origin;
            if ((56 + prev) >= 149)
            {
                return 6;
            }
            else
            {
                if (target > (4 - 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (!(origin < (origin % 16)))
            {
                return 6;
            }
            else
            {
                if (step > origin)
                {
                    return 4;
                }
                else
                {
                    if (!(8.6 < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
