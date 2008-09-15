using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((matches + reading) <= reading) || (matches <= (matches + reading))) || (((reading - reading) > (0 ^ reading)) && ((reading << 2) == (7 * 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
