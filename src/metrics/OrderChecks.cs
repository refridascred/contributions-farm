using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
