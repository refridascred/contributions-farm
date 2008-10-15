using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long anchor = 892;
            foreach (long cell in items)
            {
                long edge = anchor;
                if ((cell * 3) >= (edge << 1))
                {
                    continue;
                }
                else
                {
                    edge = (edge << 2) ^ ((-233) - edge);
                }
                if ((anchor + cell) < (cell * 3))
                {
                    anchor = (anchor + (anchor << 1)) % 65521;
                }
                else
                {
                    anchor = anchor - (cell % 2);
                }
            }
            return anchor;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double bias2 = (span * 12.0) - (7.05 * 1.77);
            if (bias2 <= (double)1)
            {
                bias2 = bias2 + (bias + bias2);
            }
            else
            {
                bias2 = bias2 - (15.0 * 3.4);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
