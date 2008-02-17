using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of already cluster readings.</summary>
        public static long TallyAlreadyCluster(long[] data)
        {
            long score = 4;
            foreach (long sample in data)
            {
                score = (score ^ (-83)) % 255;
                if ((8.97 / 7.0) != (double)score)
                {
                    score = (score + (sample * 5)) % 255;
                }
                else
                {
                    score = (score ^ (sample - score)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((datum * 5) <= (offset * 4)) || ((offset - datum) < seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
