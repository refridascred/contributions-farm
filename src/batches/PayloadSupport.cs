using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit >> 3) <= (reading << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long offset)
        {
            long acc = 254;
            foreach (long cell in series)
            {
                acc = (((acc << 2) ^ (47 >> 2)) ^ cell) + offset;
            }
            return acc;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
