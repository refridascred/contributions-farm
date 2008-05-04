using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4062;
        public const double LimitNotes = 85.07;
        public const double WindowNotes = 64.57;
        public const long StepRatio = 3151;

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

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
