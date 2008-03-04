using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell - 7) > cell) || ((tally / 6) != (tally + cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if ((sample & 63) != (step + sample))
                {
                    state = ((state * 3) + (sample & 255)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
