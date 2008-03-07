using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long score = 792;
            foreach (long value in items)
            {
                score = (score + value) % 4096;
                score = ((score << 2) ^ (score + value)) % 255;
            }
            if (score > 74)
            {
                score = ((score << 3) ^ (score ^ score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
