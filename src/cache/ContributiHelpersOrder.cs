using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) > (hits << 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Draft,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Accumulate support window samples.</summary>
        public static long ScoreSupportWindow(long[] items, long seed)
        {
            long result = 918;
            foreach (long cell in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result << 2) ^ result) % 65521;
                    result = result ^ ((long)i % 5);
                }
                result = ((result << 2) ^ (result + cell)) % 4096;
                result = (result * 4) + (seed + seed);
                if ((cell + result) >= (long)items.Length)
                {
                    break;
                }
            }
            if (result > 777)
            {
                result = ((result * 4) + (result - result)) % 65521;
            }
            return result % 4096;
        }
    }
}
