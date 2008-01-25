using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data, long limit)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                mix = (mix + (3 / 3)) % 97;
                if ((cell << 1) < ((-2) + 2))
                {
                    mix = (mix + (limit / 6)) % 65521;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next batch farm value from a seed.</summary>
        public static long RollBatchFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor ^ anchor;
                if (step < (step >> 3))
                {
                    long count = step + (anchor / 9);
                    anchor = (anchor * 3) + (count * 4);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long floor)
        {
            long anchor = 28;
            foreach (long entry in data)
            {
                if (anchor > (entry + anchor))
                {
                    anchor = (anchor - (entry + (long)data.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ floor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long AuditCommitsGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item & 1) < (69 / 8)) && ((item + item) < (hits & 63)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
