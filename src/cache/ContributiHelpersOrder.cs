using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long score = 964;
            foreach (long value in samples)
            {
                if ((value & 7) == (value - value))
                {
                    score = score + (score >> 4);
                }
            }
            return score;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long target)
        {
            long mix = 163;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (reading << 3)) % 255) + target;
            }
            return mix;
        }
    }
}
