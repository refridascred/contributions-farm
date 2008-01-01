using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((long)samples.Length < (entry % 16))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Ready,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
