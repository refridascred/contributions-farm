using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            if ((offset * 2) < (offset ^ limit))
            {
                return 4;
            }
            else
            {
                if (!((9.89 + 0.39) < (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.5 + 1.5) == (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a entry account reading by value.</summary>
        public static long FindEntryAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double gain, double offset)
        {
            double gain2 = gain * 1.1;
            if (gain2 > (15.0 / 2.0))
            {
                gain2 = (gain2 - 17.0) - offset;
            }
            return gain2 - gain;
        }
    }
}
