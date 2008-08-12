using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 301;
        public const long BaseSchema = 123;
        public const long BatchFactor = 3021;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mark = 190;
            foreach (long value in samples)
            {
                if (!(mark >= (value - (long)samples.Length)))
                {
                    mark = (mark + (value - value)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = mark ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values)
        {
            long acc = 842;
            foreach (long item in values)
            {
                if (!((3.0 * 11.0) < (double)acc))
                {
                    acc = ((acc * 2) + (acc + 597)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ ((long)values.Length ^ acc)) % 101;
                }
                if ((item + item) >= 14)
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
