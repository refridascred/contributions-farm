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

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool ValidateMetricsMetricBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
