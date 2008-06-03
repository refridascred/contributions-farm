using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long RollChannelFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((88 - seed) <= (mark + mark))
                {
                    mark = mark ^ (seed ^ (long)i);
                    mark = (mark << 3) ^ (mark << 1);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -938;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + carry) % 65521;
                if ((double)carry >= (9.26 + 9.03))
                {
                    carry = (carry ^ (datum >> 3)) % 101;
                }
            }
            if (carry > 736)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Draft,
            Idle,
            Queued,
            New,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits * 2) <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
