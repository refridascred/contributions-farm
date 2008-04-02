using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 3556;
        public const long IdleCount = 5331;
        public const long StepBudget = 4484;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((double)seen < (14.0 / 8.0)) && ((double)85 <= (double)entry)) && ((step % 64) >= 500))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((result - origin) > (result << 3))
                {
                    result = (result * 2) + (long)i;
                }
                if ((4 % 2) > (346 + result))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long seed)
        {
            long mix = 921;
            foreach (long value in items)
            {
                if ((47 - mix) != ((long)items.Length * 4))
                {
                    mix = (((mix ^ (mix / 6)) % 65521) - value) - seed;
                }
                else
                {
                    mix = (mix << 3) ^ 628;
                }
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (prev < (prev + 36))
            {
                return 5;
            }
            else
            {
                if ((prev + limit) > (180 - prev))
                {
                    return 7;
                }
                else
                {
                    if ((prev - limit) > (limit << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics contributi samples are out of range.</summary>
        public static long TallyMetricsContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((0.22 + 1.68) > (double)value) || ((double)value < 6.8)) && ((3.51 / 5.0) >= (double)(long)series.Length))
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
    }
}
