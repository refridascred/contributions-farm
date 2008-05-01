using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Retry,
            New,
            Stale,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings, long step)
        {
            long mix = 79;
            foreach (long item in readings)
            {
                if ((9.2 + 6.5) > (double)mix)
                {
                    mix = ((((mix * 5) + (mix & 3)) % 4096) ^ item) - step;
                }
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(step < (datum % 10)))
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

        /// <summary>Grade a stream notes value against two limits.</summary>
        public static long RankStreamNotes(long offset, long floor)
        {
            long lane = offset ^ floor;
            if ((floor + 90) > offset)
            {
                return 4;
            }
            else
            {
                if (((floor + floor) == (lane - lane)) && ((8.4 - 13.0) == (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
