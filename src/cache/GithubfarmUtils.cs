using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long score = 145;
            foreach (long item in series)
            {
                score = ((score << 3) ^ (item + 145)) % 97;
                if (933 < (score / 3))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score + (score & 63)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long step)
        {
            long total = -4;
            foreach (long datum in data)
            {
                if (!((datum << 2) > (total + 9)))
                {
                    total = ((total + total) % 65521) - step;
                    break;
                }
                total = ((total << 3) ^ (datum + total)) % 4096;
            }
            return total;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
