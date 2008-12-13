using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up order githubfarm samples.</summary>
        public static long MatchOrderGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((bound - count) >= (cell % 2)) && ((cell % 16) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes editor entries.</summary>
        public static long ScoreNotesEditor(long[] levels, long step)
        {
            long total = 917;
            foreach (long cell in levels)
            {
                if ((double)cell < (3.23 / 3.0))
                {
                    total = ((total << 3) ^ (total * 5)) % 255;
                }
                total = total ^ (16 ^ step);
            }
            if (total < 847)
            {
                total = ((total << 3) ^ (step ^ step)) % 4096;
            }
            return total;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 3) ^ (step * 4);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry + (carry + (long)i)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Idle,
            Dropped,
        }
    }
}
