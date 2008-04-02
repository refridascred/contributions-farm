using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a editor notes value against two limits.</summary>
        public static long GradeEditorNotes(long bound, long target)
        {
            long offset = bound ^ target;
            if ((target - bound) > (128 & 31))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long step)
        {
            if (413 > (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((step << 1) <= 57)
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset == (5.01 - 9.9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Dropped,
            Locked,
        }
    }
}
