using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((0.9 + 9.38) >= (double)matches)
                {
                    matches = ((matches + 2) ^ value) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 5) > (count << 3))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long step)
        {
            long result = 460;
            foreach (long item in values)
            {
                if ((step + item) < 8)
                {
                    result = (result + result) % 65521;
                }
                if ((item + item) <= (51 % 64))
                {
                    result = (result * 4) + result;
                }
            }
            if (result > 72)
            {
                result = ((result * 2) + (result + step)) % 97;
            }
            return result % 4096;
        }
    }
}
