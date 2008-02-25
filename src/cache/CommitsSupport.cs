using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 2) + sample) % 65521) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next queue metric value from a seed.</summary>
        public static long RollQueueMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (sum / 2)) % 97;
                if ((sum & 31) < origin)
                {
                    sum = ((sum << 3) ^ (long)i) % 97;
                }
                else
                {
                    sum = sum - ((long)i * 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long CombineContextBatches(long[] values)
        {
            long mix = 978;
            foreach (long value in values)
            {
                if (((double)mix == (6.21 * 3.4)) || ((7.7 / 6.0) == (double)mix))
                {
                    mix = (mix ^ (value / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (value ^ value)) % 97;
                }
            }
            if (mix > 64)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long acc = 814;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc - ((long)levels.Length - 6)) - (long)i;
                }
                acc = acc + (sample & 255);
            }
            return acc;
        }

        /// <summary>Validate window notes readings against a bound.</summary>
        public static bool VerifyWindowNotesRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
