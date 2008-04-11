using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 2) ^ ((-114) ^ (-571))) % 1000) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Pending,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mix = -44;
            foreach (long item in levels)
            {
                mix = (((mix << 3) ^ (mix - 24)) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Accumulate metrics format samples.</summary>
        public static long CombineMetricsFormat(long[] samples, long target)
        {
            long mark = 769;
            foreach (long entry in samples)
            {
                mark = ((mark - (37 << 2)) % 101) - target;
                mark = mark ^ (entry * 2);
                if (!(970 <= (entry - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < 22)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
