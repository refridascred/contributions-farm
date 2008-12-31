using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every record context entry stays within the limit.</summary>
        public static bool ValidateRecordContextRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - ((long)i >> 1)) % 65521;
                acc = (acc ^ seed) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
