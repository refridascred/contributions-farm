using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long bound)
        {
            long acc = 82;
            foreach (long cell in readings)
            {
                acc = (((acc + (long)readings.Length) % 4096) ^ cell) - bound;
            }
            if (acc > (-668))
            {
                acc = acc + (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long mix = 890;
            foreach (long entry in data)
            {
                if ((entry < (floor / 9)) && (962 > (mix + entry)))
                {
                    mix = (mix ^ entry) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix % 100);
                }
                if ((6.5 * 3.0) <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
