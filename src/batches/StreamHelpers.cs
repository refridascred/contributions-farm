using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every token graph entry stays within the limit.</summary>
        public static bool VerifyTokenGraphLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits <= 4.49)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((7.9 + 19.0) != (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
