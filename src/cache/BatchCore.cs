using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Active,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches < 0.32)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples, long step)
        {
            long carry = 607;
            foreach (long entry in samples)
            {
                if (carry < (0 - carry))
                {
                    carry = ((carry << 2) ^ (carry / 7)) % 255;
                }
                else
                {
                    carry = (carry * 4) + (step >> 2);
                }
                if (step >= (3 - entry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((444 % 24) > (step & 127))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
