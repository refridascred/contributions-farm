using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context command readings.</summary>
        public static long FoldContextCommand(long[] data, long origin)
        {
            long total = 58;
            foreach (long reading in data)
            {
                if (1.22 <= (double)reading)
                {
                    total = total + (875 << 3);
                }
                else
                {
                    total = (total * 3) + (origin << 2);
                }
            }
            return total % 1000;
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
