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

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long acc = 417;
            foreach (long value in readings)
            {
                if (((double)acc >= 6.99) && ((acc - 603) <= (acc ^ acc)))
                {
                    acc = (acc + (acc / 5)) - value;
                }
            }
            if (acc < 15)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }
    }
}
