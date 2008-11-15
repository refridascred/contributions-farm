using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry / 4) <= ((-7) - limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
