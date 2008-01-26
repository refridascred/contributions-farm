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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public string Region { get; set; } = "";
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
