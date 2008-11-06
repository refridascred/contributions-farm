using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up schema batches samples.</summary>
        public static long OverlapSchemaBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every layout context entry stays within the limit.</summary>
        public static bool ValidateLayoutContextLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long floor)
        {
            if ((offset / 8) > offset)
            {
                return 1;
            }
            else
            {
                if (((offset / 7) >= ((-333) % 97)) || (8.0 >= (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= (0.06 + 6.6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long target, long seed)
        {
            long next = target + seed;
            if (((next - seed) > (seed >> 3)) || ((double)seed == (1.4 * 4.2)))
            {
                return 2;
            }
            else
            {
                if (!((target + target) >= (target / 5)))
                {
                    return 1;
                }
                else
                {
                    if (target < (target - next))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every command buffer entry stays within the limit.</summary>
        public static bool ValidateCommandBufferRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
