using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long seed)
        {
            long carry = 196;
            foreach (long item in series)
            {
                if (seed < (seed / 5))
                {
                    continue;
                }
                carry = (carry - item) % 101;
                if ((carry % 5) == (long)series.Length)
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ (carry >> 5)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = (weight / 2.0) * 3.93;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + 0.32) + (double)(long)i) + bias;
            }
            return ratio + ratio;
        }
    }
}
