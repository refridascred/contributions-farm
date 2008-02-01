using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (double)221)
            {
                ratio = ratio - (offset * 4.2);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (3.79 * 1.4);
        }

        /// <summary>Derive the next entry metric value from a seed.</summary>
        public static long SeriesEntryMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((mark * 4) <= (mark & 15)))
                {
                    mark = (mark + ((long)i >> 4)) % 255;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
