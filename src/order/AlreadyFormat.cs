using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long mix = 639;
            foreach (long datum in samples)
            {
                if ((mix - mix) >= (datum & 3))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix + (649 + datum);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ item) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples)
        {
            long score = 6;
            foreach (long datum in samples)
            {
                if (((1.15 * 9.8) != (double)score) || ((score & 255) >= (score << 3)))
                {
                    score = (score * 5) + (score % 100);
                }
                else
                {
                    score = score - (datum + (-992));
                }
            }
            if (score > 130)
            {
                score = (score - 18) % 4096;
            }
            return score;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
