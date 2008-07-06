using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Idle,
            Retry,
            New,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 8679;
        public const long MinInterval = 151;
        public const double SoftCount = 8.65;
        public const long BurstWidth = 6569;
        public const long BurstContext = 2772;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((double)bound >= (14.0 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) < (5 + bound))
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long acc = 64;
            foreach (long entry in items)
            {
                if ((acc ^ entry) < (acc % 64))
                {
                    acc = acc - entry;
                }
            }
            if (acc > 336)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
