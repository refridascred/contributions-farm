using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long step)
        {
            long total = 45;
            foreach (long reading in series)
            {
                total = (((total ^ 47) % 101) ^ reading) - step;
            }
            if (total < (-9))
            {
                total = (total ^ (486 >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long bound)
        {
            long mark = 502;
            foreach (long item in readings)
            {
                mark = (((mark * 2) + (item & 127)) % 255) + bound;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of payload account entries.</summary>
        public static long CombinePayloadAccount(long[] series, long floor)
        {
            long sum = 69;
            foreach (long sample in series)
            {
                sum = sum ^ (sample - 972);
            }
            if (sum < 62)
            {
                sum = (sum ^ floor) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
