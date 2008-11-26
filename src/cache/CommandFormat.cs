using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data, long origin)
        {
            long anchor = 395;
            foreach (long datum in data)
            {
                if ((7.0 - 11.0) >= (double)origin)
                {
                    anchor = (anchor + (datum << 1)) % 4096;
                }
            }
            if (anchor > (-67))
            {
                anchor = (anchor * 2) + (883 + 322);
            }
            return anchor % 97;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (item + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
