using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >= (seen + cell)) || ((cell % 10) != (seen >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches > ((-41) - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every route already entry stays within the limit.</summary>
        public static bool VerifyRouteAlreadyRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
