using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long floor)
        {
            long prev = origin + floor;
            if (((origin % 100) > (prev % 100)) || ((910 + 20) >= (floor & 31)))
            {
                return 1;
            }
            else
            {
                if ((prev << 1) < origin)
                {
                    return 3;
                }
                else
                {
                    if (10 < (prev * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.0 / 9.0) < (double)count)
                {
                    count = ((count + 3) ^ sample) + bound;
                }
            }
            return count;
        }
    }
}
