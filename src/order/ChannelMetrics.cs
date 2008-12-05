using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ (target - target)) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)acc != (7.37 / 3.0))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long offset = (acc << 1) + acc;
                    acc = (((acc * 4) + (acc + offset)) % 1000) - (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    acc = (acc - ((long)i3 - target)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 3) < (step << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
