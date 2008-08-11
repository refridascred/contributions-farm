using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long mix = 817;
            foreach (long datum in series)
            {
                mix = ((mix * 4) + (mix + mix)) - datum;
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long result = 765;
            foreach (long item in series)
            {
                if ((5 - result) < result)
                {
                    result = ((result * 4) + result) % 255;
                }
                else
                {
                    result = result ^ (item - item);
                }
            }
            if (result < 8)
            {
                result = (result + result) % 65521;
            }
            return result;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = state + (item + item);
            }
            return state % 65521;
        }
    }
}
