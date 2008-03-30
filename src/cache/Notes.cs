using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen & 127) >= 19)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data)
        {
            long result = -7;
            foreach (long entry in data)
            {
                if ((double)entry > (double)397)
                {
                    result = ((result << 3) ^ (entry - entry)) % 101;
                }
            }
            return result;
        }

        /// <summary>Check that every cache token entry stays within the limit.</summary>
        public static bool VerifyCacheTokenBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
