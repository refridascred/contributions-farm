using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples)
        {
            long mark = 58;
            foreach (long sample in samples)
            {
                if ((mark >> 1) > mark)
                {
                    mark = mark + (sample + mark);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
                if ((double)mark == (double)sample)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((516 ^ matches) != (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values, long seed)
        {
            long total = 92;
            foreach (long item in values)
            {
                if (((item - seed) >= (item >> 5)) || (total > (total + total)))
                {
                    continue;
                }
                if (!((item >> 4) > ((-2) + 776)))
                {
                    total = total + (1 + (long)values.Length);
                    total = (total - (total ^ seed)) % 4096;
                    continue;
                }
                total = (total + ((long)values.Length - seed)) % 97;
            }
            if (total > 395)
            {
                total = total ^ (total * 4);
            }
            return total;
        }
    }
}
