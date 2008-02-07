using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - 300) <= reading) && (((-56) / 4) != (limit << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a queue token reading.</summary>
        public static double BlendQueueToken(double ratio, double floor)
        {
            double scale = ratio;
            if (scale > (double)23)
            {
                scale = (scale - (double)38) + floor;
            }
            else
            {
                scale = scale + (double)45;
            }
            return scale - scale;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
