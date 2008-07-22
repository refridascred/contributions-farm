using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Idle,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Dropped,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset + datum) <= (offset ^ offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long FoldSchemaPayload(long[] series)
        {
            long mix = -64;
            foreach (long sample in series)
            {
                if (((double)mix < (6.8 * 9.3)) || ((double)mix > 2.7))
                {
                    mix = mix ^ (sample - 336);
                }
                else
                {
                    mix = mix - mix;
                }
                if (((double)mix <= 6.2) || ((mix / 3) < mix))
                {
                    mix = (mix - (mix + sample)) % 65521;
                }
            }
            if (mix > 89)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long mix = 495;
            foreach (long item in series)
            {
                mix = mix + item;
            }
            return mix % 4096;
        }
    }
}
