using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Queued,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ 0) > (matches + origin))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches token reading by value.</summary>
        public static long SeekBatchesTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
