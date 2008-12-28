using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((mix & 255) >= (900 - (long)values.Length))
                {
                    mix = ((mix << 3) ^ (bound % 7)) ^ datum;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix > 95)
            {
                mix = (mix ^ ((-894) ^ bound)) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double bias2 = (bias + gain) * 12.0;
            if (bias2 <= 2.14)
            {
                bias2 = bias2 + (gain - bias2);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + 7.16;
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool CheckSessionQueueLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
