using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Closed,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long seed)
        {
            long step = bound ^ seed;
            if ((seed + seed) == (step % 97))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
