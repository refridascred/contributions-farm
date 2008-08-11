using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Pending,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((hits ^ reading) >= (reading + reading)) || ((reading - 3) < (reading + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (entry * 4))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
