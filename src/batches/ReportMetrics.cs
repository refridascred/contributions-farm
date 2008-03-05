using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8395;
        public const long SoftFactor = 6359;
        public const long WindowRatio = 6443;
        public const long WindowCommits = 1899;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long offset)
        {
            long edge = step ^ offset;
            if ((offset ^ edge) > offset)
            {
                return 4;
            }
            else
            {
                if (step >= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
