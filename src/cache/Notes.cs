using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool ValidateBufferLayoutLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
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
