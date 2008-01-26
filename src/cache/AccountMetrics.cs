using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (7 ^ (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit session format readings against a rule.</summary>
        public static long TallySessionFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches > (matches - value)) || ((matches & 7) >= (value - value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long acc = 40;
            foreach (long value in samples)
            {
                acc = acc ^ (value % 12);
                if (bound >= (bound + bound))
                {
                    acc = ((acc * 2) + (bound - bound)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (bound + acc)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
