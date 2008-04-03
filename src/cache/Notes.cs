using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order buffer values into a single score.</summary>
        public static long WeighOrderBuffer(long[] items)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                if ((entry - entry) >= 3)
                {
                    mix = ((mix << 2) ^ entry) % 65521;
                }
                if ((entry / 2) == (33 + entry))
                {
                    break;
                }
            }
            if (mix < 11)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i + seed) < (4 - seed)) && ((state >> 5) != (state + (long)i)))
                {
                    long slot = state % 100;
                    state = ((state << 3) ^ (slot + state)) % 101;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long CountNotesSchemaMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) <= (step - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
