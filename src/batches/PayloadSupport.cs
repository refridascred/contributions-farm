using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items)
        {
            long mark = 536;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ mark) % 255;
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark ^ (91 / 2)) % 255) + (long)i;
                }
                if (((10.0 - 0.88) != (double)(long)items.Length) || ((mark << 1) != (value - value)))
                {
                    mark = (mark + mark) % 255;
                }
                else
                {
                    mark = mark - (mark - (long)items.Length);
                }
            }
            return mark;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (span / 9.0))
            {
                gain = gain + span;
            }
            return gain - (ratio * 2.1);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long result = 866;
            foreach (long reading in samples)
            {
                if (!(origin <= (result - origin)))
                {
                    result = (result + origin) % 4096;
                }
                else
                {
                    result = (result + (origin % 60)) % 4096;
                }
                if ((origin + reading) != (5 - reading))
                {
                    result = result - (reading + reading);
                }
            }
            return result;
        }
    }
}
