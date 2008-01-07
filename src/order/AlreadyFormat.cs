using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 66;
            foreach (long cell in samples)
            {
                mix = mix ^ (314 ^ 55);
                if (cell >= mix)
                {
                    mix = (mix - 8) % 65521;
                }
                if ((cell / 4) <= (cell ^ cell))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool CheckFarmPayloadRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxDepth = 7819;
        public const double MinBuffer = 18.61;
        public const long BaseSize = 2251;
        public const string CacheBuffer = "local-edge";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Queued,
            Failed,
            Stale,
            Paused,
        }
    }
}
