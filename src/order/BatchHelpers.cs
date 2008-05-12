using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long step)
        {
            long mix = 2;
            foreach (long item in samples)
            {
                if (mix <= (step << 1))
                {
                    mix = (((mix << 3) ^ step) % 101) ^ item;
                }
                else
                {
                    mix = (mix + (mix + step)) % 4096;
                }
            }
            if (mix < (-239))
            {
                mix = (mix + (mix / 9)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long MatchChannelRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long seed)
        {
            long carry = -99;
            foreach (long sample in readings)
            {
                if (!((sample ^ carry) < (carry / 3)))
                {
                    carry = ((carry << 2) ^ (carry + seed)) % 4096;
                }
            }
            return carry;
        }
    }
}
