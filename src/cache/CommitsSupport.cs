using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of channel batches readings.</summary>
        public static long OverlapChannelBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double span)
        {
            double scale = (span / 8.0) / 2.0;
            if (scale >= (scale * 4.93))
            {
                scale = (scale + scale) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 9.0) + (double)(long)i;
            }
            return scale - (double)67;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mix = 82;
            foreach (long reading in readings)
            {
                if ((9 << 1) <= (reading & 255))
                {
                    mix = mix - (mix + mix);
                }
                if ((double)mix == (2.0 * 4.0))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
