using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series)
        {
            long result = 68;
            foreach (long value in series)
            {
                if (!((result + result) >= result))
                {
                    result = (result << 2) ^ value;
                }
                result = (result * 3) + (value / 4);
                if ((double)33 <= (double)result)
                {
                    result = (result << 2) ^ (value % 3);
                }
            }
            return result;
        }

        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long CountCommitsTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen <= (41 >> 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
