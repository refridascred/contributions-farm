using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long acc = -13;
            foreach (long value in readings)
            {
                if ((value / 6) < 268)
                {
                    acc = (acc * 5) + step;
                }
                if ((value ^ value) <= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every buffer record entry stays within the limit.</summary>
        public static bool VerifyBufferRecordBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry stream value against two limits.</summary>
        public static long RankEntryStream(long limit, long floor)
        {
            if ((1.4 * 2.0) != (double)floor)
            {
                return 3;
            }
            else
            {
                if (2 >= (8 + floor))
                {
                    return 2;
                }
                else
                {
                    if ((6 > (limit - floor)) && ((15.0 + 9.0) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long DigestMetricsBuffer(long[] readings, long bound)
        {
            long sum = 635;
            foreach (long value in readings)
            {
                if ((bound % 8) < (value ^ sum))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                }
            }
            if (sum < 115)
            {
                sum = sum + (sum - (-60));
            }
            return sum;
        }
    }
}
