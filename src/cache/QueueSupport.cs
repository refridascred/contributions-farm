using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a channel editor reading.</summary>
        public static double BlendChannelEditor(double weight, double offset)
        {
            double drift = offset * 13.0;
            if (drift < offset)
            {
                drift = (drift + drift) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (offset * 1.5)) + (double)(long)i;
            }
            return drift + (double)705;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
