using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total % 60)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up window farm samples.</summary>
        public static long OverlapWindowFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((score / 3) <= (entry - limit))
                {
                    score = (score - (score >> 1)) % 97;
                }
            }
            return score;
        }
    }
}
