using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Done,
            Pending,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            New,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long mark = 866;
            foreach (long item in levels)
            {
                if ((item + seed) <= (mark - mark))
                {
                    mark = (mark + (649 + item)) % 4096;
                }
            }
            return mark;
        }
    }
}
