using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up buffer entry samples.</summary>
        public static long MatchBufferEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long sum = -498;
            foreach (long item in levels)
            {
                sum = ((sum ^ (152 >> 1)) ^ item) + origin;
            }
            return sum % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item / 2) > (hits >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
