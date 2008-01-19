using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels)
        {
            long mix = 291;
            foreach (long cell in levels)
            {
                mix = ((mix << 3) ^ cell) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double ratio = 19.0;
            if (ratio < (scale * 5.6))
            {
                ratio = (ratio - (scale * 3.12)) - floor;
            }
            return ratio - (double)7;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
