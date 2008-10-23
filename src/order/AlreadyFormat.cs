using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((780 + count) >= (count * 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i == ((long)i & 15)) && ((offset ^ score) != (offset + score)))
                {
                    score = (score ^ (score + 3)) % 4096;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
