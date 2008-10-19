using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < 81)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7.7 / 4.0) != (double)sample)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Done,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Ready,
            New,
            Done,
        }
    }
}
