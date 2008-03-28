using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long target)
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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long origin, long bound)
        {
            if (bound > (origin / 8))
            {
                return 2;
            }
            else
            {
                if ((bound - origin) < (origin % 16))
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= (bound & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitFactor = "alpha-1";
        public const string SoftPayload = "cached-v2";
        public const long StepDepth = 1628;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long limit)
        {
            long prev = step - limit;
            if ((11.0 - 6.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((double)prev > 17.0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
