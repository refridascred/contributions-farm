using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record entry samples are out of range.</summary>
        public static long AuditRecordEntryHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((15.0 * 15.0) >= (double)reading)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = (9.38 / 3.0) + (scale + scale);
            return (drift - (scale + scale)) + offset;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long target)
        {
            if (target >= (step * 3))
            {
                return 2;
            }
            else
            {
                if (((step - step) != (8 ^ step)) && (target >= (target & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (double)(-8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
