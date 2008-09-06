using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((3.6 > (double)count) || ((count & 7) <= (floor >> 2))))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long step)
        {
            long delta = limit ^ step;
            if (limit > (88 + step))
            {
                return 4;
            }
            else
            {
                if ((step + (-991)) <= (step & 31))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) > (delta & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
