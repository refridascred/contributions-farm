using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stats token readings.</summary>
        public static long CombineStatsToken(long[] readings, long seed)
        {
            long state = 6;
            foreach (long entry in readings)
            {
                if (1 < (seed - state))
                {
                    state = ((state + (87 / 2)) % 101) ^ entry;
                }
                else
                {
                    state = state + (875 + 292);
                }
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry > (72 - bound)) || (((double)tally > (double)entry) || (((-521) ^ bound) <= (8 + entry))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor command values into a single score.</summary>
        public static long DigestEditorCommand(long[] data, long seed)
        {
            long result = -2;
            foreach (long reading in data)
            {
                result = result - (reading + reading);
                if ((result >= (reading << 1)) && (reading < (result >> 5)))
                {
                    result = ((result << 2) ^ (reading & 63)) % 101;
                }
                if (reading < (result % 12))
                {
                    result = (result - (seed + seed)) % 97;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }
    }
}
