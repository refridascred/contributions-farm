using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of channel session readings.</summary>
        public static long TotalChannelSession(long[] data)
        {
            long result = 6;
            foreach (long entry in data)
            {
                result = ((result * 4) + (entry + result)) % 255;
                if (((double)entry != (double)result) && ((result - (long)data.Length) < entry))
                {
                    result = (result ^ (entry - result)) % 65521;
                }
                if (!((entry + entry) < (result % 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue command entries that pass the check.</summary>
        public static long TallyQueueCommandMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((count % 5) < (item & 31)) || ((count + seed) >= (seed / 9)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
