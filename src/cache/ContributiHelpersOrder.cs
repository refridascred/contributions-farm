using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count counter account pairs that satisfy a relation.</summary>
        public static long OverlapCounterAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
