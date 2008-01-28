using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
