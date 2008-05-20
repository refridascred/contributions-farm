using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen < 6.37)
                {
                    seen = ((seen + 3) - cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((double)state < (2.0 / 6.0))
                {
                    state = state + ((long)readings.Length % 10);
                }
                if ((state - datum) >= (datum + (long)readings.Length))
                {
                    state = state - datum;
                }
                else
                {
                    state = (state ^ (6 - state)) % 101;
                }
            }
            if (state < 463)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (11.0 * 20.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats channel values into a single score.</summary>
        public static long TallyStatsChannel(long[] levels, long origin)
        {
            long mix = 94;
            foreach (long value in levels)
            {
                if (value >= ((-62) + origin))
                {
                    mix = ((mix * 5) + (mix + origin)) % 101;
                }
                else
                {
                    mix = (mix ^ (-7)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 2012;
        public const long BaseFarm = 6952;
        public const long MinFarm = 2489;
        public const long WindowFarm = 7325;
    }
}
