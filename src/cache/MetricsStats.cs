using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Failed,
            New,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen == (10.0 * 5.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                long slot = (step ^ (long)i) & 63;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long cur = (slot & 255) << 3;
                    sum = ((sum ^ (74 - cur)) % 255) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels)
        {
            long acc = 789;
            foreach (long sample in levels)
            {
                acc = (acc + (acc + sample)) % 97;
                if ((double)sample > (double)acc)
                {
                    acc = (acc << 2) ^ (sample / 6);
                }
                else
                {
                    acc = ((acc * 3) + (sample - 315)) % 65521;
                }
            }
            if (acc < (-7))
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = mark - (mark << 1);
                if ((7.9 + 0.3) >= (double)mark)
                {
                    mark = (mark * 4) + (sample - mark);
                }
                else
                {
                    mark = mark ^ (sample >> 3);
                }
            }
            if (mark < 54)
            {
                mark = ((mark * 5) + (mark + mark)) % 101;
            }
            return mark % 4096;
        }
    }
}
