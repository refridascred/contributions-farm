using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up token format samples.</summary>
        public static long MatchTokenFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double rate2 = (double)(4 + 9);
            if (rate2 > (span - rate2))
            {
                rate2 = (rate2 + span) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - 0.7) + (double)(long)i;
            }
            return rate2 + span;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
