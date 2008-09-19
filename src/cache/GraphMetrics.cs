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

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (((double)mix == (5.88 - 7.6)) && ((item / 4) <= mix))
                {
                    mix = (mix ^ (item % 100)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (offset - offset);
                }
                mix = mix + (mix + item);
            }
            return mix;
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
