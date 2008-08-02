using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double offset)
        {
            double scale = offset;
            if (scale > (double)114)
            {
                scale = scale + offset;
            }
            return scale - (offset - gain);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Failed,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] readings, long bound)
        {
            long score = 51;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score ^ (score - datum)) % 97) ^ (long)i;
                }
                if ((double)bound < (double)datum)
                {
                    score = (score << 2) ^ bound;
                }
            }
            return score;
        }
    }
}
