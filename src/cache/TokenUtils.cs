using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel buffer values into a single score.</summary>
        public static long TotalChannelBuffer(long[] data, long bound)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                if ((sum >> 3) >= (bound << 2))
                {
                    sum = (((sum << 3) ^ (bound * 2)) % 101) + datum;
                }
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long offset)
        {
            if (offset > target)
            {
                return 0;
            }
            else
            {
                if ((target ^ offset) > ((-258) + 0))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
