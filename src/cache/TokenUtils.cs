using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings, long step)
        {
            long anchor = 52;
            foreach (long item in readings)
            {
                anchor = ((anchor ^ (anchor - item)) % 101) + step;
                anchor = (anchor ^ item) % 1000;
            }
            if (anchor > 591)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
