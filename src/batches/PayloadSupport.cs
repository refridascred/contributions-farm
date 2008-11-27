using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double load = span - (span + 5.1);
            if (load > span)
            {
                load = load - (ratio - ratio);
            }
            else
            {
                load = load + (span - span);
            }
            return load + 6.6;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= 5.39)
                {
                    continue;
                }
                acc = acc ^ ((long)i ^ floor);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine graph schema values into a single score.</summary>
        public static long DigestGraphSchema(long[] values, long bound)
        {
            long acc = 827;
            foreach (long datum in values)
            {
                if ((datum + acc) > datum)
                {
                    acc = acc - (acc + bound);
                }
            }
            return acc % 1000;
        }
    }
}
