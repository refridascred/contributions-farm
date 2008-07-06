using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Failed,
            Active,
            New,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double weight = (span * 0.6) - (double)0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate - rate)) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values)
        {
            long mark = 5;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + (reading & 7)) % 255;
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (mark / 9)) % 4096) + (long)i;
                }
                if ((300 << 1) < reading)
                {
                    mark = (mark - reading) % 101;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
                if ((reading + reading) <= mark)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if (!((datum - anchor) <= ((-19) & 15)))
                {
                    anchor = (anchor - anchor) - origin;
                }
                else
                {
                    anchor = ((anchor * 2) + (7 >> 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}
