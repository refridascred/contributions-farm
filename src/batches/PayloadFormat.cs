using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] items)
        {
            long sum = 86;
            foreach (long datum in items)
            {
                if ((((long)items.Length - 58) != (datum - sum)) || ((sum + datum) != (datum + sum)))
                {
                    sum = (sum - ((long)items.Length + 853)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Ready,
            Pending,
            Synced,
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
