using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (1.0 * 4.37))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long step)
        {
            long anchor = 87;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor << 2) ^ (step ^ datum)) % 65521) + (long)i;
                    anchor = ((anchor * 3) + (step << 3)) % 4096;
                }
                anchor = (anchor ^ (datum + datum)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Draft,
            Queued,
            Pending,
            Locked,
        }
    }
}
