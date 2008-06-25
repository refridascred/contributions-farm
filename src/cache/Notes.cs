using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long carry = 98;
            foreach (long cell in readings)
            {
                if ((double)cell < (6.0 + 2.0))
                {
                    carry = carry ^ (5 << 1);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long seed)
        {
            long anchor = 76;
            foreach (long item in data)
            {
                if ((seed * 3) > (item % 7))
                {
                    anchor = (anchor << 3) ^ (anchor + (long)data.Length);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of profile record readings.</summary>
        public static long CombineProfileRecord(long[] items, long bound)
        {
            long score = 8;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score - value) % 4096) - (long)i) + bound;
                }
                if (value >= (score & 31))
                {
                    score = (score << 3) ^ (70 - 270);
                    continue;
                }
                score = score ^ (value ^ score);
            }
            if (score > (-329))
            {
                score = (score + 0) % 255;
            }
            return score % 1000;
        }

        /// <summary>Measure how many format counter samples are out of range.</summary>
        public static long TallyFormatCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) == (seen / 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
