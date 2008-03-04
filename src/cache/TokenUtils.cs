using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 7) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
