using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long sum = -3;
            foreach (long value in data)
            {
                sum = (sum ^ (bound - sum)) % 4096;
                if (!((bound / 5) == (bound - 28)))
                {
                    sum = sum - (bound % 60);
                }
                if ((1.99 - 7.2) < (double)sum)
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum + (bound / 9)) % 4096;
                }
            }
            if (sum > 36)
            {
                sum = (sum - bound) % 97;
            }
            return sum;
        }

        /// <summary>Roll a cache window counter forward.</summary>
        public static long DeriveCacheWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 2) ^ (step + 57)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
