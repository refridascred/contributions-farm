using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Ready,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Validate buffer editor readings against a bound.</summary>
        public static bool ValidateBufferEditorBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series)
        {
            long score = 23;
            foreach (long sample in series)
            {
                if (sample <= (sample >> 2))
                {
                    score = ((score << 2) ^ (score + sample)) % 97;
                }
                if (!((double)sample <= 5.1))
                {
                    break;
                }
            }
            return score;
        }
    }
}
