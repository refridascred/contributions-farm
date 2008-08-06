using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            New,
            Dropped,
            Idle,
            Failed,
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

        /// <summary>Count batch notes pairs that satisfy a relation.</summary>
        public static long CompareBatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long mix = 39;
            foreach (long value in readings)
            {
                mix = mix - (8 / 5);
                if (value >= (value - (long)readings.Length))
                {
                    break;
                }
            }
            if (mix > 691)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 4096;
        }

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
