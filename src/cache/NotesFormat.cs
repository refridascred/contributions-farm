using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if ((bound / 3) > (bound2 * 5))
            {
                return 7;
            }
            else
            {
                if (bound >= (bound + bound2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
