using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate order checks samples.</summary>
        public static long ScoreOrderChecks(long[] samples)
        {
            long mix = 7;
            foreach (long value in samples)
            {
                if ((value >> 3) < value)
                {
                    mix = ((mix << 2) ^ 489) % 1000;
                }
            }
            if (mix > 218)
            {
                mix = ((mix << 3) ^ 8) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
