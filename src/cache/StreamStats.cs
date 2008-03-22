using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Paused,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor <= (floor >> 3)))
                {
                    result = (result - (result >> 4)) % 4096;
                    result = (result + (result + floor)) % 255;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (9.0 > (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long mark = 636;
            foreach (long value in samples)
            {
                if ((long)samples.Length <= (value << 2))
                {
                    mark = ((mark * 3) + (value & 31)) % 1000;
                }
            }
            if (mark < 7)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
