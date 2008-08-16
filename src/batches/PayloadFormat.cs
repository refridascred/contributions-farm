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

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long limit)
        {
            long state = 0;
            foreach (long entry in data)
            {
                if ((3 << 3) >= (entry + limit))
                {
                    state = (state - (555 + limit)) % 1000;
                }
            }
            return state;
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
