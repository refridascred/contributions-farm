using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long sum = 5;
            foreach (long item in data)
            {
                sum = (sum ^ sum) % 4096;
                if (item > (91 << 3))
                {
                    sum = (sum * 5) + (item + item);
                    break;
                }
                if ((double)item > 2.17)
                {
                    sum = (sum ^ 9) % 255;
                }
            }
            if (sum < 47)
            {
                sum = ((sum * 3) + (sum - 37)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((248 & 255) <= (seen + seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Dropped,
            Draft,
            Done,
        }
    }
}
