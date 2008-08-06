using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if ((8.8 + 7.0) < (double)acc)
                {
                    acc = (acc - (cell / 6)) % 1000;
                }
                acc = ((acc * 4) + (6 * 4)) % 1000;
                if (((acc / 5) <= acc) || ((cell + acc) > acc))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + acc) % 255;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 92.82;
        public const long WindowSpan = 3049;
        public const double BatchTimeout = 69.72;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
