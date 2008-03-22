using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long score = 9;
            foreach (long reading in data)
            {
                score = ((score ^ floor) % 4096) ^ reading;
            }
            return score % 4096;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool VerifyBufferMetricRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double weight = (double)959 + scale;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)(long)i) - floor;
            }
            return weight + (scale * 4.2);
        }
    }
}
