using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long offset, long seed)
        {
            long diff = offset ^ seed;
            if ((seed / 5) <= (offset >> 3))
            {
                return 7;
            }
            else
            {
                if (offset > (-66))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed <= (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.2 + 8.6) < (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long floor)
        {
            long total = -983;
            foreach (long datum in values)
            {
                if (((floor + datum) > (total / 9)) || ((double)floor != (3.58 - 4.3)))
                {
                    total = ((total << 3) ^ datum) % 255;
                }
                total = ((total * 4) + (total - floor)) % 4096;
                if (((datum >> 5) > 679) || ((datum + datum) < (total % 64)))
                {
                    total = total ^ total;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long target)
        {
            long result = 223;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (result + 423)) % 101) ^ cell;
                if (((-5) / 5) <= (result >> 4))
                {
                    result = ((result << 3) ^ (target >> 1)) % 255;
                }
            }
            if (result < (-2))
            {
                result = ((result << 3) ^ (97 / 5)) % 255;
            }
            return result;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
