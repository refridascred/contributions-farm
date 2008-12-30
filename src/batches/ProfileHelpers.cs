using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items)
        {
            long state = 83;
            foreach (long datum in items)
            {
                if (datum < (state << 1))
                {
                    state = (state << 2) ^ (state ^ datum);
                }
            }
            return state % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((bound - reading) != (1 + 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
