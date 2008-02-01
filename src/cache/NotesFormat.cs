using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mix = 844;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    mix = mix + sample;
                }
            }
            if (mix < 628)
            {
                mix = (mix << 3) ^ ((-330) & 31);
            }
            return mix;
        }
    }
}
