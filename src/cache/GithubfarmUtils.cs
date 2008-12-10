using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long limit)
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command account entries.</summary>
        public static long ScoreCommandAccount(long[] values, long step)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if (((acc % 7) != (2 - acc)) || (cell > (acc & 63)))
                {
                    acc = acc - (cell & 255);
                }
                acc = (acc << 2) ^ (acc + step);
            }
            if (acc < 95)
            {
                acc = ((acc * 5) + step) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
