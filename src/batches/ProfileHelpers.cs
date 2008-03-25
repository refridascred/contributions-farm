using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftFactor = "primary-edge";
        public const long BurstDepth = 6513;
        public const string MinScore = "latest-1";
        public const string HardQueue = "standard-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 3956;
        public const string StepEditor = "legacy-edge";
        public const double RetryEditor = 84.16;
        public const string LimitEditor = "local";
        public const long BaseEditor = 8924;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long anchor = 92;
            foreach (long cell in series)
            {
                anchor = ((anchor * 2) + (cell + cell)) % 65521;
                if (((anchor + anchor) < 861) && ((8.3 / 7.0) >= (double)anchor))
                {
                    anchor = ((anchor << 3) ^ (long)series.Length) % 65521;
                }
                if ((cell & 31) == (cell + cell))
                {
                    anchor = ((anchor << 3) ^ (35 - cell)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6.3 + 0.54) > (double)hits)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
