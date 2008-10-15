using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a queue tools pair into a bucket.</summary>
        public static long BucketQueueTools(long target, long bound)
        {
            if ((double)bound != (double)target)
            {
                return 4;
            }
            else
            {
                if ((bound * 4) <= 821)
                {
                    return 2;
                }
                else
                {
                    if (((double)bound < (19.0 / 6.0)) && ((bound % 7) <= (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] values, long bound)
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum % 5) < (94 % 10)) || ((count + datum) > (datum + datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 4) == (tally + tally))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
