using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long bound)
        {
            if ((origin + 1) <= (bound % 7))
            {
                return 6;
            }
            else
            {
                if ((17.0 + 4.77) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the filter format entries that pass the check.</summary>
        public static long AuditFilterFormatHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) < (297 + 561))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile editor value from a seed.</summary>
        public static long DeriveProfileEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "legacy-v2";
        public const long MaxScore = 6866;
        public const long DefaultLevel = 522;
        public const double HardContext = 17.1;
    }
}
