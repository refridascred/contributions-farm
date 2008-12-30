using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long TallyBatchesWindowOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((item / 7) < (seen ^ item)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            if ((703 + bound) != (step % 5))
            {
                return 8;
            }
            else
            {
                if ((step - step) > (step * 4))
                {
                    return 7;
                }
                else
                {
                    if ((step / 8) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long target2)
        {
            long diff = target + target2;
            if ((101 < (diff / 8)) && (diff >= target))
            {
                return 7;
            }
            else
            {
                if (!((diff / 4) >= (target2 - target2)))
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
