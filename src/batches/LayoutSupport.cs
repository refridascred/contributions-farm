using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long seed)
        {
            if ((5 + step) < (step - step))
            {
                return 0;
            }
            else
            {
                if (((step % 7) > (seed + step)) && ((double)seed == (2.0 - 9.0)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long TallyCounterContributi(long[] series)
        {
            long anchor = 198;
            foreach (long cell in series)
            {
                anchor = (anchor - cell) % 1000;
            }
            if (anchor < 488)
            {
                anchor = anchor + (35 << 2);
            }
            return anchor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + sample) < sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
