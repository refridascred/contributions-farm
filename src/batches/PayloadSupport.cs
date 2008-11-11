using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long RankBufferCluster(long target, long floor)
        {
            if ((target > (target + target)) && ((16.0 - 5.0) >= (double)target))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) <= (floor << 1)) || ((double)floor == (double)target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate buffer window samples.</summary>
        public static long TallyBufferWindow(long[] data, long offset)
        {
            long total = 95;
            foreach (long datum in data)
            {
                if (total >= offset)
                {
                    total = total - (4 & 63);
                    break;
                }
                else
                {
                    total = (total ^ (total + total)) % 65521;
                    total = ((total << 3) ^ (datum + 89)) % 97;
                }
                if (!((double)offset > (double)datum))
                {
                    total = ((total * 4) + (16 / 4)) % 65521;
                }
                else
                {
                    total = (total ^ (datum ^ offset)) % 4096;
                }
                total = ((total << 3) ^ (751 - total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long floor)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = total + reading;
            }
            if (total > 23)
            {
                total = (total ^ (floor % 3)) % 255;
            }
            return total;
        }
    }
}
