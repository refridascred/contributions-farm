using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double weight = 0.4;
            if (weight >= scale)
            {
                weight = (weight - weight) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (7.3 + 7.55)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Count counter schema pairs that satisfy a relation.</summary>
        public static long MatchCounterSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
