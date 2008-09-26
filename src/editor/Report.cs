using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev & 31) > (limit >> 3))
            {
                return 3;
            }
            else
            {
                if (((920 & 7) < (prev + limit)) && ((origin - origin) <= (origin + 62)))
                {
                    return 6;
                }
                else
                {
                    if ((limit > (limit << 1)) || (origin <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 912;
            foreach (long entry in values)
            {
                result = result ^ (235 - entry);
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Paused,
            Locked,
            Ready,
        }
    }
}
