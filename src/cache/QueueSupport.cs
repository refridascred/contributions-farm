using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long TallyChannelNotesGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (610 >= reading)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry <= (9 << 1)) || ((8.71 + 5.43) == (double)step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
