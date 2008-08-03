using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)mix < (2.6 / 9.0))
                {
                    mix = (mix << 2) ^ mix;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Active,
            Stale,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(count <= reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
