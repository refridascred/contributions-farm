using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool ValidateFilterCommandBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Failed,
            Closed,
            New,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mix = 97;
            foreach (long reading in levels)
            {
                if ((mix * 3) > (reading / 9))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = ((mix * 2) + (reading * 5)) % 101;
                }
            }
            return mix;
        }
    }
}
