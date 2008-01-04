using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)count >= (double)sample) || ((count + 877) < (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinFactor = "alpha-edge";
        public const double BatchSpan = 22.75;
        public const long BatchGraph = 7965;
        public const long CacheGraph = 2944;
        public const long MinGraph = 6187;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((9 << 1) < (offset + limit))
            {
                return 0;
            }
            else
            {
                if (!((span + span) > (1 % 5)))
                {
                    return 1;
                }
                else
                {
                    if (((offset + span) <= (limit + 4)) && ((offset / 3) != (span % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span & 255) > 293)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream already entries.</summary>
        public static long TallyStreamAlready(long[] data)
        {
            long carry = 14;
            foreach (long reading in data)
            {
                carry = (carry ^ (3 >> 3)) + reading;
            }
            return carry % 65521;
        }
    }
}
