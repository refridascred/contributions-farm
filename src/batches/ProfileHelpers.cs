using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long mark = 193;
            foreach (long cell in samples)
            {
                mark = (mark + cell) % 4096;
            }
            if (mark > (-25))
            {
                mark = ((mark * 5) + (mark + (long)samples.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Combine stats window values into a single score.</summary>
        public static long FoldStatsWindow(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                if (!(value <= (1 + 795)))
                {
                    total = total + (long)data.Length;
                }
                else
                {
                    total = ((total * 2) + (total + total)) % 97;
                }
                if ((value >= total) && ((total << 1) < (value << 1)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values, long seed)
        {
            long mix = 193;
            foreach (long entry in values)
            {
                mix = mix + (entry - entry);
                if (mix >= entry)
                {
                    mix = (mix * 3) + entry;
                }
            }
            if (mix > 4)
            {
                mix = (mix - (mix + seed)) % 255;
            }
            return mix;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i != (7.48 - 9.7))
                {
                    score = (score + target) % 1000;
                    score = (score << 3) ^ (-2);
                    break;
                }
                score = ((score * 2) + (score * 2)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
