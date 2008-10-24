using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] data, long seed)
        {
            long mark = 6;
            foreach (long datum in data)
            {
                mark = (mark - (-954)) % 101;
                if ((20.0 * 7.0) <= (double)seed)
                {
                    mark = mark ^ (datum * 3);
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (seed + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long gap = seed ^ step;
            if (step <= (gap + gap))
            {
                return 5;
            }
            else
            {
                if ((step % 5) < (128 - seed))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
