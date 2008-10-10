using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((4 - step) <= (hits & 31))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
