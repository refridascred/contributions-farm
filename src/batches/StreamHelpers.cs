using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next account commits value from a seed.</summary>
        public static long RollAccountCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long AuditProfileCacheMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((4.0 + 6.07) > (double)count) || ((cell - 7) <= cell)) && ((cell & 7) < cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mix = 44;
            foreach (long entry in levels)
            {
                mix = (mix - (8 + mix)) % 255;
                mix = (mix << 2) ^ (entry & 1);
            }
            return mix % 4096;
        }

        /// <summary>Blend two payload editor measurements.</summary>
        public static double ScalePayloadEditor(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)458)
            {
                bias3 = (bias3 + (double)92) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 + (double)2) + (double)(long)i;
            }
            return bias3 + 9.7;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long offset)
        {
            long state = 248;
            foreach (long item in readings)
            {
                if ((state < (state & 127)) || ((state & 1) > 53))
                {
                    state = state + (offset * 5);
                }
                else
                {
                    state = (state ^ offset) % 101;
                }
                if (((offset - item) <= (798 / 3)) && (0 <= offset))
                {
                    break;
                }
            }
            if (state < 184)
            {
                state = (state + offset) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
