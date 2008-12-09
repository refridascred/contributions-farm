using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((16.0 - 4.0) <= (double)hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels, long bound)
        {
            long mix = 58;
            foreach (long item in levels)
            {
                mix = (((mix * 4) + (mix % 7)) + item) + bound;
            }
            if (mix < (-50))
            {
                mix = (mix * 4) + (mix / 9);
            }
            return mix;
        }
    }
}
