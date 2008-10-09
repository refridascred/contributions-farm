using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long target)
        {
            if ((target >= (target % 60)) || ((offset >> 5) <= (target - target)))
            {
                return 8;
            }
            else
            {
                if ((offset + target) >= target)
                {
                    return 7;
                }
                else
                {
                    if (target > (target - 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 95.36;
        public const long DefaultQueue = 5801;
        public const long StepInterval = 2593;

        /// <summary>Locate a format cluster reading by value.</summary>
        public static long LookupFormatClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long seed)
        {
            if ((5.0 / 9.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)offset == (17.0 - 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) != (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
