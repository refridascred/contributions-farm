using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc << 2) ^ bound) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + cell) ^ (long)i;
                }
                result = ((result * 4) + (step - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (620 > (count - count))
                {
                    count = ((count + 3) - datum) - limit;
                }
            }
            return count;
        }
    }
}
