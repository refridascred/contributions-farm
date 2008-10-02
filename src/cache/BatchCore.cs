using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format notes samples.</summary>
        public static long WeighFormatNotes(long[] values, long limit)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((cell + result) <= limit)
                {
                    result = (result + limit) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Queued,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + ((long)i << 1)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
