using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Idle,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long GradeSessionOrder(long offset, long offset2)
        {
            long step = offset - offset2;
            if (((step / 6) == (offset2 ^ offset)) || ((offset - offset2) >= (step / 6)))
            {
                return 8;
            }
            else
            {
                if (((offset2 / 9) >= (step << 1)) || (((-684) * 5) > (offset / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 2) < (step % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate order format readings against a bound.</summary>
        public static bool CheckOrderFormatBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
