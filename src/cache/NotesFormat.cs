using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long step2)
        {
            long cur = step + step2;
            if ((double)cur >= (7.29 * 2.99))
            {
                return 4;
            }
            else
            {
                if (!((step2 + step2) != (47 + step2)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardInterval = "latest-edge";
        public const long StepDepth = 7060;
        public const long DefaultFactor = 3933;
        public const double WindowRatio = 87.12;
        public const long WindowLevel = 1008;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
