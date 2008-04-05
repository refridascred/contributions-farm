using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate metric entry samples.</summary>
        public static long TallyMetricEntry(long[] series)
        {
            long result = 3;
            foreach (long value in series)
            {
                if ((result & 15) >= (value % 16))
                {
                    result = ((result * 4) + result) % 65521;
                    break;
                }
                else
                {
                    result = result + (value / 6);
                }
                if ((20 * 2) != (value - result))
                {
                    result = ((result * 3) + (97 / 7)) % 1000;
                }
                else
                {
                    result = (result - (result << 3)) % 255;
                }
            }
            return result;
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((31 % 100) >= (seed >> 1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
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
