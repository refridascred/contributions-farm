using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the route format series from a seed.</summary>
        public static long DeriveRouteFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark - (mark ^ (long)i)) % 97) + (long)i2;
                }
                mark = (mark - mark) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardSpan = "open-1";
        public const long BatchGithubfarm = 8584;
        public const long DefaultFactor = 4350;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (floor >> 5))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
