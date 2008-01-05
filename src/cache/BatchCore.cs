using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items)
        {
            long anchor = 599;
            foreach (long entry in items)
            {
                if (((-19) ^ entry) == (760 ^ anchor))
                {
                    anchor = (anchor * 5) + (anchor * 3);
                }
                else
                {
                    anchor = (anchor - (entry & 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Check that every stream githubfarm entry stays within the limit.</summary>
        public static bool CheckStreamGithubfarmRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
