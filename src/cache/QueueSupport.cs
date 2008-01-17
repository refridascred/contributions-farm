using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (origin < (origin - origin))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
