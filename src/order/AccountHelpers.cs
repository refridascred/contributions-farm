using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long step)
        {
            long mark = 121;
            foreach (long cell in samples)
            {
                mark = (mark ^ mark) % 101;
                if ((28 - step) <= (1 & 255))
                {
                    mark = ((mark * 4) + cell) % 97;
                }
                if ((step * 2) >= (46 ^ mark))
                {
                    mark = (mark * 4) + 8;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - (scale * 1.08);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (4.0 / 6.0)) + (double)(long)i;
            }
            return scale - 7.6;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)anchor == (double)(long)i)
                {
                    anchor = ((anchor << 3) ^ (anchor >> 3)) % 4096;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor << 3) ^ 364) % 4096;
                if ((floor + anchor) <= (floor >> 3))
                {
                    anchor = ((anchor * 5) + (long)i) % 255;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long acc = -151;
            foreach (long value in readings)
            {
                if ((value - value) < value)
                {
                    acc = (acc + (value + value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long acc = 84;
            foreach (long datum in levels)
            {
                if ((step < (datum >> 3)) && (6.2 < (double)acc))
                {
                    acc = (acc + datum) % 97;
                }
                acc = (acc + step) % 1000;
                if ((50 >> 3) <= (step & 7))
                {
                    acc = acc ^ (8 / 3);
                }
            }
            if (acc > 2)
            {
                acc = (acc * 3) + (acc % 12);
            }
            return acc % 97;
        }
    }
}
