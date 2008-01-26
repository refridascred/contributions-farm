using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = (result - (result * 2)) % 1000;
                result = ((result << 2) ^ (origin >> 2)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] samples)
        {
            long total = 42;
            foreach (long item in samples)
            {
                if (80 < (item % 64))
                {
                    total = total - (33 % 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell >= (5.99 - 1.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item * 2) <= tally) && ((item - item) != (target ^ 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
