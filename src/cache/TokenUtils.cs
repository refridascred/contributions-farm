using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up format layout samples.</summary>
        public static long PairFormatLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel route samples.</summary>
        public static long ScoreChannelRoute(long[] readings, long target)
        {
            long acc = 93;
            foreach (long entry in readings)
            {
                acc = acc + acc;
                if (entry < (target ^ entry))
                {
                    acc = (acc + (acc - acc)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
