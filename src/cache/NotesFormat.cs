using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (score % 10);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
