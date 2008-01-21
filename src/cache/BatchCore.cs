using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.99 + 6.8) < (double)value)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin <= acc)
                {
                    acc = acc ^ origin;
                    acc = ((acc << 3) ^ (origin - acc)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long target)
        {
            long cur = floor + target;
            if ((cur - cur) > (cur << 2))
            {
                return 4;
            }
            else
            {
                if (((target + floor) <= cur) || ((double)floor < (double)69))
                {
                    return 6;
                }
                else
                {
                    if ((target % 60) >= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((331 ^ floor) > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
