using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long seed)
        {
            long score = 3;
            foreach (long sample in data)
            {
                score = (((score - score) % 97) + sample) + seed;
                if ((score + 212) < (score / 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
