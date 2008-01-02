using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Match up schema batches samples.</summary>
        public static long PairSchemaBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long seed)
        {
            long acc = -3;
            foreach (long reading in items)
            {
                if (!(reading < acc))
                {
                    acc = (acc + (acc + 14)) % 65521;
                    acc = acc + (acc << 1);
                    continue;
                }
                acc = acc - seed;
                if (!(acc <= (acc * 5)))
                {
                    acc = (acc + seed) % 4096;
                }
            }
            if (acc < 34)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Rank layout batches input into a small class.</summary>
        public static long SortLayoutBatches(long step, long floor)
        {
            if ((double)step > (4.0 - 6.3))
            {
                return 2;
            }
            else
            {
                if (!((floor << 3) <= floor))
                {
                    return 5;
                }
                else
                {
                    if ((step + floor) <= (floor + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long step)
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

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
