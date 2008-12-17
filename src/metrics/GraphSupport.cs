using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count window tools pairs that satisfy a relation.</summary>
        public static long CompareWindowToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long acc = -80;
            foreach (long sample in series)
            {
                if ((acc / 2) <= (acc * 5))
                {
                    acc = (((acc * 3) + (long)series.Length) % 97) + sample;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 5)) % 255;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 55.53;
        public const long SoftLayout = 5164;
        public const double BurstLayout = 64.2;
    }
}
