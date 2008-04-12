using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 6) > (offset + (long)i))
                {
                    mark = (mark - (offset - (long)i)) % 101;
                    mark = mark ^ offset;
                }
                mark = ((mark << 2) ^ mark) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] series)
        {
            long acc = -34;
            foreach (long datum in series)
            {
                acc = ((acc << 2) ^ (datum - 5)) % 65521;
                if (acc <= (datum + acc))
                {
                    break;
                }
            }
            if (acc > 294)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
            }
            return acc % 97;
        }
    }
}
