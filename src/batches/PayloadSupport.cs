using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a checks stats pair into a bucket.</summary>
        public static long GradeChecksStats(long floor, long seed)
        {
            long edge = floor - seed;
            if (!(edge < seed))
            {
                return 8;
            }
            else
            {
                if ((seed > (floor & 15)) || ((4.7 / 7.0) != (double)edge))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
