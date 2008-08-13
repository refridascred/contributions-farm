using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a counter queue sample.</summary>
        public static long SeekCounterQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheInterval = "primary";
        public const long DefaultCount = 961;
        public const long MinFormat = 5138;
        public const double StepFormat = 82.95;
        public const long StepDepth = 452;

        /// <summary>Combine graph format values into a single score.</summary>
        public static long FoldGraphFormat(long[] items, long offset)
        {
            long carry = 62;
            foreach (long cell in items)
            {
                carry = (((carry - carry) % 1000) + cell) - offset;
            }
            return carry % 1000;
        }
    }
}
