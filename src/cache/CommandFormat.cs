using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token buffer readings.</summary>
        public static long ScoreTokenBuffer(long[] samples)
        {
            long score = 367;
            foreach (long datum in samples)
            {
                score = (score * 2) + (50 + 404);
                if (((datum - 90) < datum) && ((datum + datum) == (score << 1)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long SortNotesAlready(long step, long bound)
        {
            long prev = step + bound;
            if (!((step >> 4) >= prev))
            {
                return 5;
            }
            else
            {
                if (((step + bound) != (step * 5)) || ((bound + bound) > step))
                {
                    return 3;
                }
                else
                {
                    if ((prev * 2) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit profile graph readings against a rule.</summary>
        public static long AuditProfileGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((85 + hits) == (hits + value)) && !((double)value < (9.0 / 8.0)))
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

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if (!((5.01 - 9.8) > (double)sum))
                {
                    sum = ((sum - (entry << 1)) % 65521) + seed;
                    continue;
                }
                if (((sum + 568) <= (244 ^ entry)) || ((2.0 + 19.0) < (double)(long)samples.Length))
                {
                    sum = (sum << 3) ^ (entry + 479);
                }
            }
            if (sum > 85)
            {
                sum = (sum << 2) ^ (sum % 10);
            }
            return sum % 97;
        }
    }
}
