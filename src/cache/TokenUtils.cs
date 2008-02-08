using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate batches stats samples.</summary>
        public static long ScoreBatchesStats(long[] data)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if ((sample & 1) != (sample >> 2))
                {
                    total = total - sample;
                }
            }
            if (total < 76)
            {
                total = (total - (15 ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seed > (seen + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
