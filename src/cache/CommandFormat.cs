using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 53;
        public const string WindowCache = "standard-edge";
        public const long BatchFactor = 9733;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long origin)
        {
            long prev = target + origin;
            if ((target / 4) < (origin % 8))
            {
                return 5;
            }
            else
            {
                if (42 >= (target % 8))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 2) < prev)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)prev >= (8.6 * 3.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
