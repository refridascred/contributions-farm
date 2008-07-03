using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data, long step)
        {
            long mark = 85;
            foreach (long entry in data)
            {
                if (!((8.2 * 10.0) > (double)entry))
                {
                    mark = mark ^ (entry - mark);
                }
                else
                {
                    mark = ((mark * 5) + (step >> 4)) % 1000;
                }
                if (!((mark + 982) <= (entry ^ (long)data.Length)))
                {
                    mark = (mark + step) % 65521;
                }
                if ((double)step != (2.92 / 4.0))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (mark / 9)) % 101;
            }
            return mark;
        }

        /// <summary>Match up order queue samples.</summary>
        public static long MatchOrderQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
