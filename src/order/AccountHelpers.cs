using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long floor)
        {
            long sum = 141;
            foreach (long entry in items)
            {
                if ((double)entry < (4.7 + 15.0))
                {
                    sum = (sum + (entry + floor)) % 65521;
                }
                if ((sum & 1) > (sum + entry))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((item % 12) < 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen ^ 54) != (seen + 6))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already queue sample.</summary>
        public static long FindAlreadyQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
