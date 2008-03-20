using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema tools entries.</summary>
        public static long CombineSchemaTools(long[] samples)
        {
            long sum = 470;
            foreach (long item in samples)
            {
                sum = (sum << 3) ^ (sum / 6);
                if (!(701 >= (sum * 2)))
                {
                    sum = (sum + item) % 255;
                    sum = (sum + (item * 3)) % 65521;
                }
                if (((sum % 10) > (sum & 31)) || (sum >= (item * 3)))
                {
                    sum = (sum ^ (sum + sum)) % 101;
                }
                if ((item + item) == (item << 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format metrics series from a seed.</summary>
        public static long RollFormatMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (offset ^ sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
