using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Active,
            Stale,
            New,
        }

        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long GradeQueueCluster(long origin, long bound)
        {
            if (!((bound ^ bound) <= bound))
            {
                return 7;
            }
            else
            {
                if (6.63 <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
