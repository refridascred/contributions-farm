using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((8.0 + 3.5) > (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
