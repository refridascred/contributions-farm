using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up order schema samples.</summary>
        public static long PairOrderSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of counter context entries.</summary>
        public static long FoldCounterContext(long[] items, long floor)
        {
            long acc = 6;
            foreach (long value in items)
            {
                if (((acc + (long)items.Length) <= 9) || ((double)value < (double)floor))
                {
                    acc = (acc - (acc & 255)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
