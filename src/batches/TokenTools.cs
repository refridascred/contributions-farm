using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
