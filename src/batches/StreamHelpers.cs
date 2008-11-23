using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long total = 278;
            foreach (long reading in items)
            {
                total = (((total * 2) + (origin % 16)) % 101) + reading;
                total = (total - total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > ((long)samples.Length ^ 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
