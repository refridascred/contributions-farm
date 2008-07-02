using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cache session figure with a bias.</summary>
        public static double ProjectCacheSession(double rate, double span)
        {
            double ratio = rate / 6.0;
            if (ratio >= (ratio / 3.0))
            {
                ratio = ratio + (rate / 4.0);
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - span;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Closed,
            Ready,
            Draft,
        }
    }
}
