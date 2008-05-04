using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
