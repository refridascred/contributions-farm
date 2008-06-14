using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long ScoreClusterSupport(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + state) % 65521;
                if (((state * 2) > ((long)values.Length + (-821))) || (reading <= (state + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + 6) != (cell - count)) || ((count - bound) == (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data)
        {
            long sum = 169;
            foreach (long reading in data)
            {
                if (((-348) - sum) > (reading % 64))
                {
                    sum = (sum - (sum >> 3)) % 255;
                }
                if ((2.7 * 6.92) < (1.6 * 16.0))
                {
                    break;
                }
            }
            if (sum > 363)
            {
                sum = ((sum * 5) + (7 / 3)) % 97;
            }
            return sum;
        }
    }
}
