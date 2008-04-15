using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (double)floor)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long TallyLayoutPayload(long[] series)
        {
            long acc = 97;
            foreach (long reading in series)
            {
                acc = (acc << 2) ^ (reading - acc);
            }
            if (acc > 824)
            {
                acc = ((acc << 2) ^ (acc >> 4)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Paused,
            Retry,
        }
    }
}
