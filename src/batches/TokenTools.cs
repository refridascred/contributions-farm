using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long offset)
        {
            long acc = 43;
            foreach (long reading in levels)
            {
                if ((double)reading >= 9.0)
                {
                    acc = (((acc << 3) ^ (38 ^ reading)) % 4096) - offset;
                }
                if (!(49 <= (acc - (-595))))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
