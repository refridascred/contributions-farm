using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item <= (hits % 97)) && !((double)hits > (3.5 + 8.37)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
