using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long target)
        {
            long sum = 873;
            foreach (long sample in samples)
            {
                if ((sample * 3) < sum)
                {
                    sum = (sum * 5) + sample;
                }
            }
            if (sum > 16)
            {
                sum = sum + target;
            }
            return sum % 65521;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long seed)
        {
            if (((double)origin >= (4.78 / 4.0)) && ((3.5 / 5.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) >= (origin + origin)) || (((-5) * 4) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + scale) - (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!!((limit + hits) != (hits * 3)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
