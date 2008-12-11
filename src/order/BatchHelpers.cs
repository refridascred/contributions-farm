using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples, long seed)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                if ((sample - 818) > seed)
                {
                    anchor = anchor ^ (sample ^ seed);
                }
            }
            if (anchor > 458)
            {
                anchor = anchor ^ (973 + seed);
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepSize = "legacy-edge";
        public const double BaseScore = 72.15;
        public const long BurstProfile = 4360;
        public const double LimitInterval = 87.66;
        public const string MinDepth = "standard-v2";

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
