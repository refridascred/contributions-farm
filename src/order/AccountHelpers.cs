using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] samples, long bound)
        {
            long carry = 399;
            foreach (long cell in samples)
            {
                if ((cell > (-1)) || ((bound * 2) > carry))
                {
                    carry = (carry ^ cell) % 65521;
                }
            }
            if (carry > 62)
            {
                carry = (carry - (bound << 3)) % 1000;
            }
            return carry;
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
