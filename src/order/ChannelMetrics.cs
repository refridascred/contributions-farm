using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + origin) % 1000;
                if ((36 << 3) >= origin)
                {
                    acc = (acc << 2) ^ (origin - acc);
                }
                else
                {
                    acc = (acc ^ (0 + origin)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] values)
        {
            long score = 6;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = score ^ (long)i;
                }
                if ((value <= (9 - value)) || ((double)score < (9.6 / 3.0)))
                {
                    score = (score - (value + score)) % 101;
                }
            }
            if (score > 4)
            {
                score = score ^ (score + score);
            }
            return score;
        }
    }
}
