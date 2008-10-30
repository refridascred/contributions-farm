using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((46 - value) <= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data, long limit)
        {
            long mix = 61;
            foreach (long value in data)
            {
                mix = ((mix * 2) + 32) % 1000;
                if (((value - limit) <= value) || ((double)mix >= 19.0))
                {
                    mix = (mix + (5 * 4)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batch route input into a small class.</summary>
        public static long ClassifyBatchRoute(long seed, long seed2)
        {
            if ((double)seed != (7.8 - 2.5))
            {
                return 1;
            }
            else
            {
                if (seed2 < (702 - seed2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
