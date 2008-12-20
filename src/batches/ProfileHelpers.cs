using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 631;
        public const long MinBatch = 4795;
        public const long WindowSize = 1812;
        public const string SoftBatch = "stable-1";
        public const double IdleBatch = 97.1;

        /// <summary>Fold a list of checks route readings.</summary>
        public static long FoldChecksRoute(long[] series, long offset)
        {
            long result = 54;
            foreach (long item in series)
            {
                if ((double)result > 12.0)
                {
                    result = (result + item) - offset;
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long seed)
        {
            if (seed > 9)
            {
                return 2;
            }
            else
            {
                if (origin <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (0.36 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
