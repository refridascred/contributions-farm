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

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm context readings.</summary>
        public static long CombineFarmContext(long[] levels, long bound)
        {
            long mark = -95;
            foreach (long cell in levels)
            {
                if (!((cell - mark) <= bound))
                {
                    mark = mark + (mark ^ mark);
                }
                mark = (mark << 2) ^ (long)levels.Length;
            }
            return mark % 97;
        }
    }
}
