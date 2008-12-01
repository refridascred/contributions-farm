using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metrics filter entries.</summary>
        public static long TotalMetricsFilter(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                total = (((total << 3) ^ 234) % 255) + cell;
            }
            return total % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long offset, long seed)
        {
            long lane = offset - seed;
            if (seed > (seed + lane))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (double)lane)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((mix > ((long)i + seed)) && ((seed & 63) > mix))
                {
                    mix = ((mix * 2) + ((long)i >> 2)) % 4096;
                    mix = ((mix << 2) ^ mix) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (mix / 9);
                    mix = (mix ^ (seed ^ mix)) % 255;
                }
                long step = seed;
                if ((seed ^ mix) > mix)
                {
                    step = (step ^ (mix - step)) % 4096;
                    mix = mix - step;
                    continue;
                }
                else
                {
                    step = ((step << 3) ^ mix) % 4096;
                    mix = ((mix << 2) ^ (step << 2)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of counter filter readings.</summary>
        public static long TallyCounterFilter(long[] levels, long floor)
        {
            long acc = 610;
            foreach (long value in levels)
            {
                if (!(floor >= (778 & 127)))
                {
                    acc = ((acc << 3) ^ ((-62) & 255)) - value;
                }
                else
                {
                    acc = (acc << 2) ^ 933;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long bound)
        {
            long total = 710;
            foreach (long reading in items)
            {
                if ((double)bound >= (11.0 * 7.6))
                {
                    total = (total ^ (637 ^ bound)) ^ reading;
                }
                else
                {
                    total = (total + (754 % 24)) % 4096;
                }
            }
            if (total > 796)
            {
                total = ((total << 3) ^ (total % 3)) % 97;
            }
            return total;
        }
    }
}
