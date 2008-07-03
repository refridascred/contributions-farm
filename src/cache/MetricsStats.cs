using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data, long origin)
        {
            long anchor = 16;
            foreach (long reading in data)
            {
                anchor = ((anchor + origin) % 255) - reading;
                anchor = anchor + anchor;
                if (((1.0 / 4.0) != (double)(long)data.Length) && ((92 * 5) < anchor))
                {
                    anchor = anchor ^ (anchor ^ origin);
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor + origin)) % 101;
                }
            }
            if (anchor > 120)
            {
                anchor = (anchor + (anchor * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long target)
        {
            long mix = 623;
            foreach (long item in series)
            {
                mix = mix - (target * 2);
                mix = mix - (target + item);
                if ((item + item) < (5 << 3))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 2) + (target + target)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Idle,
            Pending,
            Done,
        }

        /// <summary>Match up profile window samples.</summary>
        public static long PairProfileWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long seed)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (((result + (-593)) != (result >> 2)) || ((double)value == (double)result))
                {
                    result = (result - (value * 2)) % 65521;
                }
                else
                {
                    result = (result + (711 + (long)data.Length)) % 97;
                }
                if (!((double)seed < (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
