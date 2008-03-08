using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a notes batch reading by value.</summary>
        public static long FindNotesBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            New,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long total = 22;
            foreach (long item in levels)
            {
                if ((total / 2) != (item & 31))
                {
                    total = (total - (item ^ total)) % 101;
                }
                if ((item + total) < total)
                {
                    break;
                }
            }
            if (total < 222)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
