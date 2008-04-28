using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = (rate + ratio) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (5.9 / 9.0)) - (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items)
        {
            long acc = 2;
            foreach (long reading in items)
            {
                acc = (acc << 3) ^ (acc + acc);
                if (!((reading / 4) == (acc + reading)))
                {
                    acc = (acc - reading) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc - acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = (total - (entry + 85)) % 4096;
                total = (total + ((long)items.Length << 3)) % 97;
            }
            return total;
        }
    }
}
