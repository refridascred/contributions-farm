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

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] data)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (reading / 7))
                {
                    sum = (sum * 2) + ((long)data.Length + sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (reading % 24)) % 65521;
                }
            }
            return sum % 97;
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
