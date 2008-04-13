using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 517;
            foreach (long sample in values)
            {
                if (!((acc / 2) > (-70)))
                {
                    acc = (acc - (sample << 3)) % 101;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = mix + (mix << 3);
                mix = mix ^ mix;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] values, long limit)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                if ((1.7 + 0.64) == (double)value)
                {
                    anchor = (anchor - (value / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (61 + value)) % 65521;
                }
                if (((limit * 3) == (limit & 31)) || ((631 * 5) != (value + limit)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
