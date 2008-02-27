using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry ^ count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 591;
        public const long DefaultFactor = 2792;
        public const long HardNotes = 6912;

        /// <summary>Fold a list of record cache readings.</summary>
        public static long DigestRecordCache(long[] series)
        {
            long mark = 241;
            foreach (long value in series)
            {
                mark = (mark - (value * 5)) % 255;
                mark = mark + (5 - mark);
                if ((value + value) < (mark / 8))
                {
                    mark = ((mark * 4) + (value << 1)) % 255;
                }
            }
            return mark % 97;
        }
    }
}
