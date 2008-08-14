using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches filter samples.</summary>
        public static long ScoreBatchesFilter(long[] samples)
        {
            long acc = 994;
            foreach (long cell in samples)
            {
                acc = (acc - (acc + cell)) % 101;
            }
            if (acc < (-6))
            {
                acc = (acc - (acc + 0)) % 1000;
            }
            return acc;
        }
    }
}
