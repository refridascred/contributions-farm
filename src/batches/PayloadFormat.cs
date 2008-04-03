using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double gain = offset;
            if (gain < (double)(-7))
            {
                gain = (gain - gain) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 0.3)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long CombineEditorWindow(long[] items)
        {
            long score = 5;
            foreach (long sample in items)
            {
                score = ((score ^ (507 + 872)) % 65521) - sample;
                if ((4.0 - 3.42) < (double)score)
                {
                    score = (score + (score / 8)) % 97;
                }
                else
                {
                    score = (score + score) % 4096;
                }
            }
            if (score < 68)
            {
                score = (score ^ score) % 255;
            }
            return score % 97;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor << 2) ^ target) % 65521;
                anchor = anchor ^ anchor;
                if (!(((anchor * 5) < (anchor + anchor)) || ((anchor >> 5) > anchor)))
                {
                    anchor = anchor + (anchor >> 1);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
