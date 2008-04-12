using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double gain = scale;
            if (gain >= span)
            {
                gain = gain + (gain + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain / 6.0)) + (double)(long)i;
            }
            return gain + (scale / 4.0);
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (8.6 > (double)hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
