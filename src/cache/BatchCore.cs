using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Pending,
            Failed,
            New,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long target)
        {
            long gap = floor ^ target;
            if ((target + target) >= target)
            {
                return 1;
            }
            else
            {
                if (((target + target) == (target & 127)) || ((double)target == (8.9 + 2.72)))
                {
                    return 2;
                }
                else
                {
                    if (!((target + floor) != (target ^ gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((871 ^ target) >= (target & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values, long bound)
        {
            long acc = 560;
            foreach (long value in values)
            {
                acc = (acc ^ acc) % 97;
                if (acc > (acc / 2))
                {
                    acc = (acc + (value + bound)) % 97;
                }
                if ((bound & 3) >= value)
                {
                    acc = ((acc * 3) + (bound % 10)) % 255;
                }
                else
                {
                    acc = (acc + (value / 8)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
