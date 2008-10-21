using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double weight = offset;
            if (weight > (offset * 2.5))
            {
                weight = weight - offset;
            }
            return weight + (17.0 + bias);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 5806;
        public const long CacheBatches = 7430;
        public const double DefaultBatches = 30.81;

        /// <summary>Grade a support checks value against two limits.</summary>
        public static long SortSupportChecks(long step, long bound)
        {
            if ((0.5 / 5.0) >= (double)step)
            {
                return 1;
            }
            else
            {
                if ((1.6 >= (double)step) || ((94 - bound) == (step + 3)))
                {
                    return 4;
                }
                else
                {
                    if ((53 < (step - bound)) && ((step - 4) <= (bound - 116)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.05 + 4.0) < (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long bound)
        {
            long lane = limit + bound;
            if ((7.09 * 14.0) == (double)lane)
            {
                return 2;
            }
            else
            {
                if (!((limit * 4) >= (limit ^ bound)))
                {
                    return 6;
                }
                else
                {
                    if (limit > (lane / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
