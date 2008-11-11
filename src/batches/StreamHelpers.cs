using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1297;
        public const double WindowLevel = 21.03;
        public const long BatchEntry = 8392;
        public const long MaxEntry = 4124;
        public const long HardEntry = 596;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor << 3) ^ (anchor % 2)) ^ (long)i2;
                    anchor = (anchor ^ anchor) % 65521;
                }
                anchor = (anchor ^ (offset >> 4)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((603 % 7) < hits) && (((reading << 1) <= reading) || ((9 / 2) < hits)))
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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long target)
        {
            long next = offset + target;
            if (!((3 + offset) < next))
            {
                return 5;
            }
            else
            {
                if ((199 >> 5) >= next)
                {
                    return 2;
                }
                else
                {
                    if ((next + next) != (target >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long limit)
        {
            if ((double)step > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((step + step) == (limit + step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
