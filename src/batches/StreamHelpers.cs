using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate profile record readings against a bound.</summary>
        public static bool VerifyProfileRecordBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long limit)
        {
            long edge = target + limit;
            if ((edge << 1) >= (47 + target))
            {
                return 5;
            }
            else
            {
                if (!(edge >= (edge - 86)))
                {
                    return 6;
                }
                else
                {
                    if ((target & 31) >= (limit + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 3) + (long)i;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc + (floor - (long)i2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                if (!(total >= target))
                {
                    total = (total * 4) + (total + 43);
                }
                if ((total / 3) <= target)
                {
                    total = (total - (total - 0)) % 97;
                }
                if ((target * 2) != (long)i)
                {
                    total = ((total << 2) ^ target) % 65521;
                    break;
                }
                else
                {
                    total = (total * 3) + (long)i;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
