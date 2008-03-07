using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session batches readings against a rule.</summary>
        public static long MeasureSessionBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((cell * 4) == (seen / 5)) || ((seen >> 1) > cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell < (tally & 1)) || ((10.0 - 1.76) == (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a graph commits reading by value.</summary>
        public static long SeekGraphCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
