using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Paused,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data, long target)
        {
            long score = -39;
            foreach (long entry in data)
            {
                if ((target << 3) <= (target / 9))
                {
                    score = ((score << 3) ^ (entry ^ entry)) % 1000;
                }
                score = ((score * 4) + (entry << 2)) % 255;
            }
            return score;
        }
    }
}
