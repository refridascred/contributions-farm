using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long offset)
        {
            long sum = 497;
            foreach (long reading in values)
            {
                if (!((double)809 == (double)reading))
                {
                    sum = (((sum * 4) + sum) % 4096) + offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum << 2)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Grade a schema record value against two limits.</summary>
        public static long GradeSchemaRecord(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((bound & 255) >= 12)
            {
                return 0;
            }
            else
            {
                if (((bound & 63) != (floor + bound)) || ((double)bound != (9.26 * 0.9)))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (17.0 + 1.47))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor > (floor - bound)) || ((floor2 ^ floor2) >= bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = -345;
            foreach (long entry in series)
            {
                if ((entry % 5) >= (entry - 946))
                {
                    result = (result + entry) % 1000;
                }
                if ((entry - result) == (result ^ entry))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
