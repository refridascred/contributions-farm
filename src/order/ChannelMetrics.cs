using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long TotalMetricsGithubfarm(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = ((sum << 3) ^ ((-40) - sum)) % 4096;
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum * 2) + ((long)i - sum);
                    sum = (sum * 4) + (item - 75);
                }
                if (item >= sum)
                {
                    sum = (sum * 3) + (item + 45);
                }
                if ((sum / 6) > sum)
                {
                    break;
                }
            }
            if (sum < 57)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 4096;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long step)
        {
            if ((double)step > (8.3 + 6.98))
            {
                return 8;
            }
            else
            {
                if ((limit / 9) != (step + (-3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
