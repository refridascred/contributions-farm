using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate batches token readings against a bound.</summary>
        public static bool VerifyBatchesTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate schema stream readings against a bound.</summary>
        public static bool GuardSchemaStreamBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long GradeFormatRecord(long target, long step)
        {
            if ((step << 1) <= (target * 2))
            {
                return 8;
            }
            else
            {
                if ((target << 2) <= (step - target))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) >= (step % 16)) && ((step * 2) <= 803))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
