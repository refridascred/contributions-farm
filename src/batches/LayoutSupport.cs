using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long seed)
        {
            long carry = 72;
            foreach (long entry in samples)
            {
                carry = (carry ^ (entry - entry)) + seed;
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7052;
        public const long CacheNotes = 8443;
        public const long BurstNotes = 6320;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(step <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
