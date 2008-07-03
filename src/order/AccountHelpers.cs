using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long mix = -6;
            foreach (long entry in readings)
            {
                mix = (mix ^ target) % 4096;
                if (((double)target == (9.0 - 8.34)) || (((long)readings.Length ^ (long)readings.Length) < (target / 4)))
                {
                    mix = (mix + entry) % 65521;
                }
                if (((mix - 7) < mix) || ((mix - target) > (target ^ entry)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a tools record pair into a bucket.</summary>
        public static long ClassifyToolsRecord(long offset, long bound)
        {
            if (offset < (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((36 << 2) >= (bound >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)917 <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 7491;
        public const string DefaultEntry = "staging-1";
        public const double BurstScore = 63.63;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if ((floor + 57) <= (27 + target))
            {
                return 6;
            }
            else
            {
                if (!((floor & 31) >= (6 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
