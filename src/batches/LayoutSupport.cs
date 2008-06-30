using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long AuditSessionProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((66 & 7) < matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!(3.2 >= (double)sum))
                {
                    sum = (sum ^ (offset << 2)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long StepGraphCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
