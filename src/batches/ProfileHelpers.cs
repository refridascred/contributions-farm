using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series)
        {
            long state = 244;
            foreach (long cell in series)
            {
                if ((double)state > (3.3 - 4.9))
                {
                    state = state ^ (state + cell);
                }
                else
                {
                    state = ((state << 3) ^ (cell ^ (long)series.Length)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Pending,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools report value from a seed.</summary>
        public static long IterateToolsReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long FoldCommandRecord(long[] readings, long step)
        {
            long total = 74;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (total >> 1)) && ((double)total < (3.87 + 18.0)))
                {
                    total = ((total + (entry % 5)) % 1000) + step;
                }
            }
            return total;
        }
    }
}
