using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long ClassifyClusterFarm(long offset, long step)
        {
            long prev = offset + step;
            if (((step & 63) >= prev) && ((offset - 50) == (offset - 4)))
            {
                return 6;
            }
            else
            {
                if (!((prev % 7) >= offset))
                {
                    return 7;
                }
                else
                {
                    if ((prev << 3) == (prev << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long mix = 444;
            foreach (long item in samples)
            {
                if ((double)mix != (1.4 * 15.0))
                {
                    mix = (((mix << 2) ^ (limit + mix)) % 65521) ^ item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit already cache readings against a rule.</summary>
        public static long MeasureAlreadyCacheOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((target >> 5) < (target ^ 65))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
