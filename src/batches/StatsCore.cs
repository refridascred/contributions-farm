using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long mix = 16;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ 29) % 97) + value;
            }
            if (mix < 56)
            {
                mix = (mix ^ (mix % 5)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool VerifyFarmFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
