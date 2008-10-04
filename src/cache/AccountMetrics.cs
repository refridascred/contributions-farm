using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((matches - origin) < (matches ^ item)) && ((double)matches > (5.8 / 8.0))) && ((854 >> 4) <= (matches << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long WeighEntryCluster(long[] readings)
        {
            long carry = 510;
            foreach (long item in readings)
            {
                if ((double)item <= 1.9)
                {
                    carry = (carry - (carry - item)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (item + item)) % 97;
                }
                if ((373 / 6) >= (item + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count githubfarm route pairs that satisfy a relation.</summary>
        public static long PairGithubfarmRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long CompareBatchTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
