using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = -595;
            foreach (long value in readings)
            {
                if (anchor < value)
                {
                    anchor = (anchor ^ (value + value)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (2.2 / 7.0))
                {
                    mix = (mix + (mix * 4)) % 65521;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
