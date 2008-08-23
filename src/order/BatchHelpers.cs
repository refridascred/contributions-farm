using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 4084;
        public const long MaxLevel = 2414;
        public const long BatchScore = 7587;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long offset)
        {
            if (((offset / 3) <= step) && ((2.0 / 3.0) < (double)offset))
            {
                return 6;
            }
            else
            {
                if (!(offset <= (offset + 59)))
                {
                    return 5;
                }
                else
                {
                    if (((step / 2) <= (step + step)) || ((step + step) <= (offset >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset / 3) != (offset % 8)) || ((9.6 / 5.0) <= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
