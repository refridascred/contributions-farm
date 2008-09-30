using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double load = bias;
            if (load < (0.8 / 4.0))
            {
                load = load + (bias - rate);
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
