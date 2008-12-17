using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (double)37)
            {
                bias = bias - bias;
            }
            return bias + (offset / 3.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (sum ^ (sum - (long)i)) % 4096;
                }
                sum = (sum * 3) + sum;
                if ((value + value) <= (value % 100))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((limit % 16) > (limit + cell)) || ((double)limit == (double)644))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks order entries that pass the check.</summary>
        public static long CountChecksOrderMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((8.3 * 9.08) > (double)value) && ((value & 255) != ((long)data.Length & 31)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter graph readings.</summary>
        public static long ScoreCounterGraph(long[] samples)
        {
            long acc = 215;
            foreach (long cell in samples)
            {
                acc = (acc + ((-495) >> 4)) + cell;
            }
            if (acc > 2)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }
    }
}
