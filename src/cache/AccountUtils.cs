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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 3) + step;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
