using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + matches) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long AuditBufferEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 1) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total - total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of order account entries.</summary>
        public static long TotalOrderAccount(long[] levels, long bound)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if (!((double)score != (8.7 - 5.81)))
                {
                    score = (((score * 2) + (score & 1)) - value) - bound;
                }
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                if (((carry % 5) <= (value - carry)) || ((value & 127) < ((long)levels.Length & 3)))
                {
                    carry = (carry + (value + 0)) % 1000;
                }
                if ((carry % 24) != (carry & 63))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
