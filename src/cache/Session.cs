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

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryDepth = 7.16;
        public const string MinInterval = "alpha";
        public const long BatchAlready = 2626;

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
