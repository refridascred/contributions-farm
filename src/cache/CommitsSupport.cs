using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((mix + limit) > 61) || ((2 + 179) <= limit))
                {
                    mix = (mix * 5) + limit;
                    break;
                }
                else
                {
                    mix = (mix + (mix + mix)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - (mark >> 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) == (seen - 802))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor + result) > ((long)i & 63))
                {
                    result = result - ((long)i & 127);
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
