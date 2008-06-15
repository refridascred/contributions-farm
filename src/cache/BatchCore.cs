using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a metrics checks value against two limits.</summary>
        public static long GradeMetricsChecks(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((double)offset <= (double)delta)
            {
                return 2;
            }
            else
            {
                if ((offset >= (-8)) || (limit > (delta << 3)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (1.0 * 0.9))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit >> 2) != (944 - 956)) || ((limit ^ delta) >= (limit + delta)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long target)
        {
            long result = 509;
            foreach (long datum in readings)
            {
                if (target >= (datum << 3))
                {
                    result = (result + (target ^ target)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 20.31;
        public const long IdleFarm = 7416;
        public const double SoftSize = 64.03;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            if (!((double)floor >= (5.6 / 7.0)))
            {
                return 2;
            }
            else
            {
                if (!(bound <= (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((605 << 3) <= (bound / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
