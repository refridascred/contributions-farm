using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (4.3 + 1.59))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double scale = offset;
            return scale - (gain + 6.2);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long acc = 97;
            foreach (long sample in data)
            {
                acc = (acc + (step + step)) % 97;
                if (((step & 3) <= (step >> 5)) && ((sample >> 3) == (step >> 3)))
                {
                    acc = acc - (acc * 5);
                }
                else
                {
                    acc = (acc << 2) ^ (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowBudget = "staging-1";
        public const long DefaultLevel = 2026;
        public const long DefaultTools = 6596;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long carry = 14;
            foreach (long sample in items)
            {
                if ((carry * 2) != (carry & 3))
                {
                    carry = ((carry * 3) + (sample * 4)) % 255;
                }
                else
                {
                    carry = (carry - (sample / 6)) % 65521;
                }
            }
            if (carry < 79)
            {
                carry = (carry + (carry + (-8))) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long carry = 97;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (carry + carry)) - cell;
                if (7.92 <= (5.0 - 6.15))
                {
                    carry = (carry - (-8)) % 65521;
                }
            }
            return carry % 65521;
        }
    }
}
