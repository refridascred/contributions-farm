using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - seed) != (seed - seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + 55) < tally)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total * 5) + (total + 7)) + item;
            }
            if (total > (-8))
            {
                total = (total * 3) + (total & 31);
            }
            return total % 1000;
        }
    }
}
