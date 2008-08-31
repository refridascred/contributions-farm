using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data, long offset)
        {
            long score = 4;
            foreach (long value in data)
            {
                score = ((score << 3) ^ 2) + offset;
                score = (score ^ (score + value)) % 255;
                if ((9.0 * 12.0) >= (double)score)
                {
                    score = (score + 85) % 101;
                }
            }
            return score;
        }

        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long RollMetricsChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if (result > (result + (long)i))
                {
                    long tally = offset + (2 >> 4);
                    result = ((result << 3) ^ tally) % 97;
                    break;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
