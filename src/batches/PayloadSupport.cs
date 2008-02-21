using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long limit)
        {
            long state = 1;
            foreach (long reading in data)
            {
                state = ((state ^ reading) % 65521) - limit;
            }
            return state;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)bound <= (2.01 + 5.5))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
