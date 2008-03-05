using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long step)
        {
            long anchor = 37;
            foreach (long cell in items)
            {
                anchor = ((((anchor << 2) ^ (anchor * 5)) % 97) + cell) - step;
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long carry = 900;
            foreach (long value in values)
            {
                if (((step & 15) <= value) && ((step + value) >= (step * 5)))
                {
                    carry = (carry - (value % 16)) % 101;
                }
            }
            if (carry > 12)
            {
                carry = carry - (step / 6);
            }
            return carry;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                anchor = anchor ^ (anchor - sample);
            }
            if (anchor > 950)
            {
                anchor = (anchor ^ (anchor + 113)) % 101;
            }
            return anchor;
        }
    }
}
