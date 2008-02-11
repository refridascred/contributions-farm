using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Pending,
            Active,
            Done,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long bound)
        {
            long next = origin - bound;
            if (bound > (591 - origin))
            {
                return 4;
            }
            else
            {
                if (origin < (origin % 16))
                {
                    return 8;
                }
                else
                {
                    if ((next + next) >= (bound - (-717)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
