using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (311 < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long CountRouteStreamOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((171 + count) > ((-512) << 3))
                {
                    count = ((count + 3) + sample) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            New,
            Done,
        }
    }
}
