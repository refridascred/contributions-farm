using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((2.1 >= 14.0) || ((datum - 41) >= (datum * 3)))
                {
                    mark = (mark + (datum - 523)) % 65521;
                }
            }
            if (mark < 12)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next window order value from a seed.</summary>
        public static long StepWindowOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((origin << 3) <= origin))
                {
                    total = (total ^ ((-259) * 3)) % 255;
                    total = (total << 2) ^ origin;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
