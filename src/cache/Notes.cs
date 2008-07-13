using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (41 > sample)
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long bound)
        {
            long anchor = 261;
            foreach (long reading in series)
            {
                if (((bound + bound) != (bound - reading)) || ((reading << 3) < (anchor + bound)))
                {
                    anchor = (anchor + (anchor + reading)) % 4096;
                }
            }
            if (anchor > 283)
            {
                anchor = ((anchor * 5) + bound) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Project the next command cluster value.</summary>
        public static double ProjectCommandCluster(double gain, double bias)
        {
            double ratio = 2.05;
            if (ratio >= 7.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (gain / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) - (double)(long)i;
            }
            return ratio + (bias - 9.8);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Stale,
            Closed,
            Done,
            Failed,
        }
    }
}
