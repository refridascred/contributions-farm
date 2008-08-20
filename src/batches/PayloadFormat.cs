using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] samples, long target)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                if ((3.9 * 9.19) <= (double)target)
                {
                    acc = (acc + (long)samples.Length) ^ entry;
                }
            }
            if (acc > (-203))
            {
                acc = (acc - (acc + target)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long MeasureRouteOrderMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally <= datum)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long origin)
        {
            long step = target ^ origin;
            if (origin < (step << 3))
            {
                return 4;
            }
            else
            {
                if (16 >= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
