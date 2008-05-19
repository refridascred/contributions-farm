using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch context input into a small class.</summary>
        public static long BucketBatchContext(long step, long step2)
        {
            long step3 = step + step2;
            if ((step2 <= (step2 / 5)) || (step2 <= (step - step)))
            {
                return 5;
            }
            else
            {
                if (step > (step2 * 4))
                {
                    return 6;
                }
                else
                {
                    if (((step3 & 7) < (step + step)) && (step2 <= 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step2 > (9.95 * 2.9)) && ((step & 31) < (step2 * 2)))
                        {
                            return 8;
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
}
