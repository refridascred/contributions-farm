using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample & 3) != (99 / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (long)i) % 4096;
                acc = (acc ^ ((long)i % 60)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
