using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token metric readings.</summary>
        public static long TallyTokenMetric(long[] series, long step)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = (((score << 3) ^ (64 % 24)) % 97) - entry;
                if ((score - step) <= (6 << 3))
                {
                    break;
                }
            }
            if (score > 15)
            {
                score = ((score * 2) + (step + score)) % 65521;
            }
            return score;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((9.14 * 0.28) <= (13.0 * 0.8))
                {
                    matches = ((matches + 2) - reading) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate channel metric readings against a bound.</summary>
        public static bool CheckChannelMetricRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
