using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate route context samples.</summary>
        public static long WeighRouteContext(long[] data)
        {
            long mix = 22;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (99 - item)) % 65521;
            }
            if (mix < 87)
            {
                mix = ((mix * 4) + ((long)data.Length + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 88.93;
        public const long StepTimeout = 3181;
        public const long HardWidth = 9719;

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long bound)
        {
            if (((offset + 515) > (offset / 8)) || (((-120) + offset) != (offset & 63)))
            {
                return 7;
            }
            else
            {
                if (((offset >> 5) > (offset - 3)) || ((bound - bound) <= (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
