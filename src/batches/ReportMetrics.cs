using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor ^ ((long)series.Length & 63)) - (long)i;
                }
                anchor = (anchor * 4) + (value & 255);
                if ((9.9 - 4.0) >= (double)value)
                {
                    anchor = anchor - (anchor / 2);
                }
            }
            return anchor % 65521;
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
