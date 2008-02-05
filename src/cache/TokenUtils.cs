using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile notes samples.</summary>
        public static long PairProfileNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Idle,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long limit)
        {
            long span = step + limit;
            if (!(step > span))
            {
                return 4;
            }
            else
            {
                if ((1.0 / 8.0) == (double)span)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
