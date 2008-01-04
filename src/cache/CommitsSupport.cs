using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long ScoreBatchWindow(long[] data, long step)
        {
            long mix = -1;
            foreach (long cell in data)
            {
                if (!((5 - cell) == (4 + step)))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                if ((cell / 9) > (mix * 3))
                {
                    mix = mix + step;
                }
                else
                {
                    mix = (mix ^ 8) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long acc = 241;
            foreach (long item in data)
            {
                if ((double)item >= (double)acc)
                {
                    acc = (acc + (item - item)) % 1000;
                }
            }
            if (acc > 827)
            {
                acc = (acc << 3) ^ (acc ^ 825);
            }
            return acc;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long sum = 301;
            foreach (long reading in levels)
            {
                if (sum >= (54 + sum))
                {
                    sum = sum - ((-7) + reading);
                }
                if ((8 <= (reading - sum)) || ((double)reading != (6.1 * 3.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Grade a counter cache value against two limits.</summary>
        public static long GradeCounterCache(long limit, long origin)
        {
            if (((-6) + limit) > (origin - limit))
            {
                return 0;
            }
            else
            {
                if (origin <= (limit * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
