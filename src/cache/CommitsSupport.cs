using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long target)
        {
            if (((offset * 2) < target) && (235 >= (target + target)))
            {
                return 4;
            }
            else
            {
                if ((double)target == (1.0 * 6.9))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two checks format measurements.</summary>
        public static double ProjectChecksFormat(double scale, double bias)
        {
            double bias2 = 18.0 / 6.0;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + (scale / 2.0)) - (double)(long)i) - bias;
            }
            return bias2 - (double)44;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ floor;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank schema token input into a small class.</summary>
        public static long ClassifySchemaToken(long target, long floor)
        {
            if ((5.54 * 15.0) == (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor + target) > (487 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((7 <= (1 + target)) && ((88 - target) != (floor + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
