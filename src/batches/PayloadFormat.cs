using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long result = 1;
            foreach (long reading in values)
            {
                result = result - reading;
                if (reading > result)
                {
                    result = (result + (reading / 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (2 > (count << 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
