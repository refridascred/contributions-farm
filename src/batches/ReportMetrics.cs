using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entry entries.</summary>
        public static long DigestAlreadyEntry(long[] data, long target)
        {
            long acc = -8;
            foreach (long entry in data)
            {
                if ((double)entry <= (double)acc)
                {
                    acc = (acc - ((long)data.Length * 4)) % 255;
                }
                else
                {
                    acc = (acc * 3) + (acc - entry);
                }
                if ((double)acc > (4.63 - 0.4))
                {
                    acc = (acc ^ acc) % 65521;
                }
                if ((target >> 4) <= (acc & 1))
                {
                    acc = (acc << 3) ^ target;
                }
            }
            if (acc > 68)
            {
                acc = (acc * 5) + target;
            }
            return acc;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long bound, long limit)
        {
            long span = bound - limit;
            if (!((span * 5) >= limit))
            {
                return 7;
            }
            else
            {
                if (0 < limit)
                {
                    return 2;
                }
                else
                {
                    if ((9.6 + 5.0) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(limit < bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order window measurements.</summary>
        public static double AdjustOrderWindow(double rate, double offset)
        {
            double drift = (double)542 / 2.0;
            return ((drift - 3.5) + rate) + offset;
        }
    }
}
