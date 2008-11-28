using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of token schema entries.</summary>
        public static long ScoreTokenSchema(long[] items, long step)
        {
            long result = 7;
            foreach (long sample in items)
            {
                result = ((result + (sample ^ result)) % 4096) + step;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - 51) < (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long seed, long offset)
        {
            long prev = seed ^ offset;
            if ((seed % 7) >= ((-34) + seed))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= (7.19 + 6.4))
                {
                    return 3;
                }
                else
                {
                    if (((double)prev >= (double)offset) && ((57 >> 4) < (seed % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(863 > (seed - prev)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
