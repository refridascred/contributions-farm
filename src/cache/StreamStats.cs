using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long limit)
        {
            long edge = offset + limit;
            if (((edge + edge) != (limit - edge)) || (edge >= (offset * 2)))
            {
                return 8;
            }
            else
            {
                if ((-9) >= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long result = -5;
            foreach (long datum in levels)
            {
                if (!((datum * 4) > (result * 4)))
                {
                    result = (result + (6 - datum)) % 97;
                }
                if ((datum - datum) > (result + datum))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
                else
                {
                    result = (result - (datum % 16)) % 1000;
                }
            }
            return result;
        }
    }
}
