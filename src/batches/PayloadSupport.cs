using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long limit)
        {
            if ((target - limit) < ((-884) / 9))
            {
                return 3;
            }
            else
            {
                if ((33 - limit) < (limit ^ 95))
                {
                    return 1;
                }
                else
                {
                    if ((double)target != (8.0 / 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long CountContributiStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(matches <= (85 + bound)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
