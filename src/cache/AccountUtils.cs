using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Ready,
            Draft,
            New,
            Idle,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if (2.12 >= (double)mix)
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = mix ^ ((long)i + mix);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long CountBatchesAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2.7 + 3.5) == (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
