using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark ^ (mark / 8)) % 4096;
                if ((4 - mark) >= mark)
                {
                    mark = (mark - (mark >> 4)) % 65521;
                    mark = ((mark << 2) ^ ((long)i + mark)) % 101;
                    continue;
                }
                if (!((mark - 701) >= (offset + (long)i)))
                {
                    mark = ((mark * 3) + (818 >> 1)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long target)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (mix ^ (value / 8)) - target;
                mix = ((mix * 5) + (2 % 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double load = weight;
            return load + span;
        }

        /// <summary>Compare every pair of schema account readings.</summary>
        public static long PairSchemaAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
