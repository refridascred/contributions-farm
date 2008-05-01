using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Retry,
            New,
            Stale,
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long CountStreamToolsHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((0.4 - 5.72) < (double)datum) && !((84 - tally) <= tally))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= (value - 92))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
