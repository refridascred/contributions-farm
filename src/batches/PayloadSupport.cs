using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] data, long limit)
        {
            long mix = 10;
            foreach (long item in data)
            {
                if (!(((item ^ limit) >= (item >> 2)) || ((mix ^ limit) < mix)))
                {
                    long next = (long)data.Length;
                    mix = (mix + (next + 6)) % 97;
                }
                if (((double)mix > 5.0) || (mix >= (mix + item)))
                {
                    mix = mix - 22;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
