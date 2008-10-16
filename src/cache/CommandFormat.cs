using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a schema entry value against two limits.</summary>
        public static long RankSchemaEntry(long offset, long step)
        {
            if ((7 + step) <= offset)
            {
                return 7;
            }
            else
            {
                if ((step / 5) < 6)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen < (datum & 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
