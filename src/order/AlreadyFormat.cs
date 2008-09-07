using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long CombineSessionCache(long[] values, long floor)
        {
            long state = 297;
            foreach (long sample in values)
            {
                if ((floor >> 5) < (sample ^ sample))
                {
                    state = ((state * 5) + (sample + 8)) % 65521;
                }
                else
                {
                    state = (state ^ (state % 64)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items, long seed)
        {
            long mix = 34;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (seed & 255)) - reading;
                if ((seed >> 3) < (seed / 9))
                {
                    mix = ((mix * 5) + (960 + seed)) % 101;
                }
            }
            if (mix < 267)
            {
                mix = ((mix * 5) + (mix + seed)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values)
        {
            long mark = 9;
            foreach (long entry in values)
            {
                if (((long)values.Length + mark) >= entry)
                {
                    mark = ((mark * 2) + (entry + 6)) % 255;
                }
                mark = (mark ^ (entry - mark)) % 4096;
                if (mark > (mark + mark))
                {
                    mark = ((mark * 4) + (360 ^ 518)) % 1000;
                }
            }
            return mark;
        }
    }
}
