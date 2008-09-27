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

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double bias2 = (6.34 - bias) / 9.0;
            if (bias2 > (offset * 3.0))
            {
                bias2 = bias2 + (offset * 9.14);
            }
            else
            {
                bias2 = bias2 + (bias - offset);
            }
            return bias2 + offset;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
