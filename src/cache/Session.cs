using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double drift = rate;
            if (drift < floor)
            {
                drift = drift + (rate / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)119) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (7.08 >= (double)item)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already farm entries.</summary>
        public static long WeighAlreadyFarm(long[] values)
        {
            long anchor = 67;
            foreach (long entry in values)
            {
                anchor = ((anchor - (anchor / 8)) % 97) + entry;
            }
            if (anchor < 627)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 97;
            }
            return anchor;
        }
    }
}
