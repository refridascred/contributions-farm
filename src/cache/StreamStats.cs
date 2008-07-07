using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long floor)
        {
            long mix = 330;
            foreach (long datum in data)
            {
                if (mix > (floor ^ datum))
                {
                    mix = mix + (326 + mix);
                }
                if (((datum ^ mix) < datum) && (mix <= 48))
                {
                    mix = ((mix << 3) ^ 238) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
