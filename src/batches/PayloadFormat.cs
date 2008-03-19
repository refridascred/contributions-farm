using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                if (total <= (reading - reading))
                {
                    total = (total ^ (target * 4)) % 255;
                }
            }
            return total;
        }
    }
}
