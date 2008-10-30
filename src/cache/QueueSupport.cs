using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long seed, long seed2)
        {
            long lane = seed + seed2;
            if (((-940) + seed2) < (seed2 >> 4))
            {
                return 4;
            }
            else
            {
                if ((-359) >= seed)
                {
                    return 8;
                }
                else
                {
                    if ((86 << 3) < lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (mix - (sample ^ floor)) % 1000;
                mix = (mix - (67 ^ floor)) % 101;
                mix = mix - (floor + floor);
            }
            if (mix < 75)
            {
                mix = (mix * 2) + ((long)values.Length + floor);
            }
            return mix % 1000;
        }
    }
}
