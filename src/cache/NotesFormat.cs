using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (target >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long StepFormatCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
