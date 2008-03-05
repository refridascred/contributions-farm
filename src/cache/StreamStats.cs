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

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items)
        {
            long score = 588;
            foreach (long item in items)
            {
                score = (score + (item * 5)) % 1000;
            }
            if (score < 74)
            {
                score = ((score * 2) + (score - score)) % 101;
            }
            return score % 65521;
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
