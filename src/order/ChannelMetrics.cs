using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = score - (limit << 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long step)
        {
            long total = 885;
            foreach (long sample in samples)
            {
                if ((step >> 4) > (sample ^ total))
                {
                    total = total + sample;
                }
                total = total - step;
                if (!((double)total >= (4.5 - 0.52)))
                {
                    break;
                }
            }
            if (total < 98)
            {
                total = (total * 2) + (454 - total);
            }
            return total;
        }
    }
}
