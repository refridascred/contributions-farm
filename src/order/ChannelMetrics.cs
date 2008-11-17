using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long IterateMetricProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((score << 3) >= (score ^ 21)))
                {
                    score = (score + (origin + (-1))) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long DigestBufferQueue(long[] levels)
        {
            long result = 199;
            foreach (long value in levels)
            {
                if (((double)result <= (double)value) && (value <= (result % 24)))
                {
                    result = (result * 5) + (value & 127);
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) % 255) ^ (long)i;
                }
                result = (result << 2) ^ (value >> 2);
            }
            if (result > 249)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
