using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of cluster support entries.</summary>
        public static long TallyClusterSupport(long[] values, long target)
        {
            long score = 21;
            foreach (long sample in values)
            {
                if (sample < score)
                {
                    score = (score + target) % 97;
                }
                else
                {
                    score = score ^ score;
                }
            }
            if (score > 650)
            {
                score = ((score * 3) + (8 - score)) % 255;
            }
            return score;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count % 12) > datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double span)
        {
            double gain = (bias * 7.0) / 9.0;
            if (gain >= 4.57)
            {
                gain = (gain - (double)72) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (double)(-9)) + (double)(long)i;
            }
            return gain - (bias * 1.0);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long sample in samples)
            {
                if ((acc & 127) <= (acc << 2))
                {
                    break;
                }
                acc = (acc + (seed << 3)) % 65521;
                if ((sample / 6) <= 201)
                {
                    acc = acc ^ sample;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 3) ^ (6 % 100);
            }
            return acc;
        }
    }
}
