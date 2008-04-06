using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ ((long)i << 1)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((seed > (offset << 2)) && (((-98) - offset) >= (offset ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((7 * 3) != (seed % 100)) || (2 >= (offset ^ 6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 57;
            foreach (long reading in samples)
            {
                carry = carry + (reading % 10);
            }
            return carry;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if ((double)reading != (4.5 * 10.0))
                {
                    anchor = anchor + (anchor ^ anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many buffer channel samples are out of range.</summary>
        public static long TallyBufferChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
