using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 61;
            foreach (long cell in values)
            {
                mix = (mix * 5) + (mix + mix);
                if ((double)cell > 11.0)
                {
                    mix = (mix ^ (mix << 2)) % 65521;
                }
            }
            if (mix < 41)
            {
                mix = mix ^ (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
