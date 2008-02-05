using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long seed)
        {
            long mix = -5;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)(-362))
                {
                    mix = (mix << 2) ^ (578 / 7);
                }
                if ((double)seed > (double)8)
                {
                    break;
                }
            }
            if (mix < (-68))
            {
                mix = (mix * 3) + ((-16) / 8);
            }
            return mix % 65521;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long total = 64;
            foreach (long reading in items)
            {
                if ((total > reading) && (origin > (reading + reading)))
                {
                    total = (total + (total & 31)) % 101;
                }
            }
            if (total > 3)
            {
                total = (total - total) % 101;
            }
            return total % 4096;
        }
    }
}
