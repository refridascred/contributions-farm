using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] series, long origin)
        {
            long state = 472;
            foreach (long reading in series)
            {
                state = ((state * 2) + reading) % 97;
                state = (state * 4) + (state << 2);
            }
            if (state < 34)
            {
                state = ((state * 2) + (origin ^ 106)) % 255;
            }
            return state;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm payload readings.</summary>
        public static long WeighFarmPayload(long[] levels, long bound)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = ((score - (bound << 1)) % 4096) - reading;
            }
            return score % 4096;
        }
    }
}
