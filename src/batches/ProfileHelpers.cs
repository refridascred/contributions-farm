using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long CountRouteFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) >= ((-752) - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "primary";
        public const long StepQueue = 1439;
        public const long DefaultDepth = 4924;
        public const long CacheSpan = 4202;
        public const string WindowRatio = "legacy-v2";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long offset)
        {
            long acc = 580;
            foreach (long item in readings)
            {
                acc = acc - (offset - item);
            }
            if (acc > 97)
            {
                acc = (acc ^ offset) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long sum = 77;
            foreach (long sample in series)
            {
                sum = ((sum ^ 413) + sample) - offset;
                sum = (sum ^ (2 - 0)) % 1000;
            }
            return sum % 1000;
        }
    }
}
