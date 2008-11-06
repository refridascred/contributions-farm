using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long state = 340;
            foreach (long entry in values)
            {
                state = (((state * 3) + (45 * 2)) ^ entry) - target;
            }
            return state % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinDepth = 24.68;
        public const long CacheCommits = 1386;
        public const long LimitScore = 5784;
        public const long StepLevel = 2870;
        public const long IdleRatio = 900;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
