using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Closed,
            New,
            Queued,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample * 5) >= ((-214) + offset)) || ((573 % 10) != (sample - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
