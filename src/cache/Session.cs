using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long sum = 318;
            foreach (long cell in data)
            {
                if (!((7 - 762) == (cell + sum)))
                {
                    sum = (sum - (cell & 1)) - origin;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data)
        {
            long mix = 537;
            foreach (long item in data)
            {
                if (((item - item) < (-8)) || ((item + item) == (mix + item)))
                {
                    mix = mix - (item + mix);
                }
            }
            if (mix < 999)
            {
                mix = ((mix << 3) ^ (816 + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double gain2 = span * 8.0;
            if (gain2 < (gain - 2.2))
            {
                gain2 = gain2 - (7.0 * 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}
