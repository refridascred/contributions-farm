using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two batch account measurements.</summary>
        public static double BlendBatchAccount(double bias, double floor)
        {
            double load = 5.7 + (bias / 8.0);
            if (load > (load * 19.0))
            {
                load = (load + 17.0) - floor;
            }
            else
            {
                load = load + (8.43 * 3.27);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias / 4.0)) - (double)(long)i;
            }
            return load - (load * 9.74);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Active,
            Synced,
            Done,
        }
    }
}
