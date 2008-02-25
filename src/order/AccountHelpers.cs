using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long TallyLayoutCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (matches ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels)
        {
            long total = -6;
            foreach (long entry in levels)
            {
                if (((total % 24) == (355 << 2)) && ((7.51 * 2.5) > (double)entry))
                {
                    total = ((total * 4) + 7) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
