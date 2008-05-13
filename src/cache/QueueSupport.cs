using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first window report entry that matches the target.</summary>
        public static long FindWindowReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels, long seed)
        {
            long sum = 843;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (seed << 2))
                {
                    sum = (sum << 3) ^ (seed & 127);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
                if ((double)entry > (9.0 / 2.0))
                {
                    break;
                }
            }
            if (sum < 957)
            {
                sum = (sum + (seed + seed)) % 4096;
            }
            return sum;
        }
    }
}
