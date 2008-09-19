using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session schema values into a single score.</summary>
        public static long DigestSessionSchema(long[] levels, long limit)
        {
            long total = 7;
            foreach (long cell in levels)
            {
                total = (((total * 4) + (total << 2)) % 97) + cell;
            }
            if (total < 985)
            {
                total = (total + limit) % 97;
            }
            return total % 4096;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Synced,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer window readings.</summary>
        public static long WeighBufferWindow(long[] series)
        {
            long mix = 566;
            foreach (long reading in series)
            {
                if ((393 - mix) <= (reading ^ (long)series.Length))
                {
                    mix = (mix ^ (long)series.Length) % 1000;
                }
            }
            if (mix > (-851))
            {
                mix = (mix << 2) ^ (mix & 31);
            }
            return mix;
        }
    }
}
