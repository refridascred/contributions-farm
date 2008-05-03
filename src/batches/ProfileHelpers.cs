using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (1.0 - 10.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a command tools value against two limits.</summary>
        public static long SortCommandTools(long limit, long target)
        {
            if (((7.0 - 4.0) != (double)limit) || ((target + target) > target))
            {
                return 8;
            }
            else
            {
                if ((4.08 / 2.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((5 % 16) <= (limit - limit)) && ((target + limit) <= (limit / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long limit, long floor)
        {
            if (((6 / 6) > floor) || ((floor % 2) < 517))
            {
                return 2;
            }
            else
            {
                if (((13.0 / 5.0) >= (double)limit) || ((limit + (-37)) > (limit & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((1.43 - 12.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double ratio = (double)(156 + 253);
            return (ratio + bias) + rate;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
