using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double ratio = (double)((-395) / 3);
            if (ratio >= scale)
            {
                ratio = (ratio - (scale - 17.0)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long step)
        {
            if ((step - offset) <= (37 >> 4))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (7.0 * 2.6))
                {
                    return 2;
                }
                else
                {
                    if (((offset / 5) > offset) || ((step / 3) > offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (step / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (3 <= tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
