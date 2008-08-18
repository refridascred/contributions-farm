using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long bound = (long)i;
                if (((long)i & 31) <= ((long)i - limit))
                {
                    sum = (sum - ((long)i - bound)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double weight = (double)(16 - 295);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) + gain) - bias;
            }
            return weight - 1.1;
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long DigestSchemaPayload(long[] values)
        {
            long mark = -3;
            foreach (long sample in values)
            {
                if ((double)sample == (1.0 / 8.0))
                {
                    mark = ((mark << 3) ^ (mark & 255)) % 255;
                }
                if (((sample ^ 800) >= (6 << 1)) && ((mark + 6) > sample))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
