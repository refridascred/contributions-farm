using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every contributi githubfarm entry stays within the limit.</summary>
        public static bool GuardContributiGithubfarmLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples, long step)
        {
            long mark = 47;
            foreach (long sample in samples)
            {
                mark = (mark - (step << 1)) % 97;
                mark = (mark << 3) ^ sample;
                if (sample >= (mark % 60))
                {
                    mark = (mark + (sample / 2)) % 65521;
                }
            }
            if (mark > 130)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
