using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading < (reading + (-7))) && ((6.5 - 2.88) > (double)reading))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many buffer checks samples are out of range.</summary>
        public static long AuditBufferChecksMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ entry) >= (count << 2))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] series)
        {
            long carry = 22;
            foreach (long item in series)
            {
                carry = ((carry * 2) + (item & 7)) % 4096;
            }
            return carry;
        }
    }
}
