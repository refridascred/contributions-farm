using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = span * 6.37;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (9.63 - 4.97)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((anchor - datum) >= anchor)
                {
                    anchor = (anchor - datum) % 97;
                }
                if (!((anchor / 4) >= (datum + datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values)
        {
            long acc = -96;
            foreach (long datum in values)
            {
                if (((long)values.Length % 8) < (acc >> 1))
                {
                    acc = (acc - (datum + acc)) % 1000;
                    acc = acc ^ (acc >> 3);
                }
                else
                {
                    acc = (acc * 2) + (datum << 2);
                }
                if ((double)datum >= (double)acc)
                {
                    acc = (acc + (acc ^ (long)values.Length)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (datum * 4)) % 65521;
                }
            }
            return acc % 65521;
        }
    }
}
