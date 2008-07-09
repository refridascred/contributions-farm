using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((target / 7) < ((long)levels.Length + 43))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 53;
            foreach (long item in samples)
            {
                if ((item > (818 ^ item)) && (sum <= (item ^ item)))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                else
                {
                    sum = sum ^ (item + 660);
                }
                sum = ((sum * 5) + (item + (-31))) % 65521;
                if ((293 + (long)samples.Length) >= (89 / 3))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            New,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
