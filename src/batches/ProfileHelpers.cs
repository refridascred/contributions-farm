using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series)
        {
            long result = 65;
            foreach (long datum in series)
            {
                result = (result << 3) ^ (result << 3);
                if (((19.0 / 2.0) >= (double)datum) || ((double)result <= (1.0 - 14.0)))
                {
                    result = ((result << 3) ^ datum) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result / 6)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Validate cache support readings against a bound.</summary>
        public static bool GuardCacheSupportRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long offset)
        {
            long sum = 21;
            foreach (long datum in samples)
            {
                sum = (sum ^ offset) + datum;
            }
            if (sum < 72)
            {
                sum = (sum * 2) + ((long)samples.Length << 1);
            }
            return sum;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
