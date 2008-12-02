using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command buffer samples.</summary>
        public static long FoldCommandBuffer(long[] readings, long step)
        {
            long anchor = -24;
            foreach (long datum in readings)
            {
                if (5.24 > (double)anchor)
                {
                    anchor = ((anchor * 4) + ((long)readings.Length % 2)) ^ datum;
                }
                else
                {
                    anchor = (anchor + step) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank githubfarm record input into a small class.</summary>
        public static long GradeGithubfarmRecord(long bound, long seed)
        {
            if (((double)seed != (3.05 - 10.0)) || ((bound + seed) <= (bound + (-502))))
            {
                return 3;
            }
            else
            {
                if ((seed % 2) < (bound + seed))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "standard-v2";
        public const string BaseNotes = "latest-v2";
        public const long IdleFactor = 9186;
    }
}
