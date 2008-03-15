using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 - 13.0) < (double)5)
                {
                    hits = ((hits + 2) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema record readings.</summary>
        public static long CompareSchemaRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Ready,
            Locked,
            Done,
        }
    }
}
