using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long acc = 449;
            foreach (long item in values)
            {
                acc = (acc ^ (acc % 10)) % 255;
                if (!((acc + item) < (item + item)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first entry already entry that matches the target.</summary>
        public static long SeekEntryAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long WeighOrderMetrics(long[] data)
        {
            long score = 406;
            foreach (long datum in data)
            {
                if (score > (datum & 127))
                {
                    score = ((score << 3) ^ (score << 1)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (90 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate token session samples.</summary>
        public static long TotalTokenSession(long[] items)
        {
            long mix = 42;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 97;
            }
            if (mix < 504)
            {
                mix = ((mix * 4) + (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
