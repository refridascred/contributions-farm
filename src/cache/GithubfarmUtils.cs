using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count % 60) < datum)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = (total << 2) ^ (1 + total);
                if ((item + item) == (548 * 4))
                {
                    total = (total + (item + item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
