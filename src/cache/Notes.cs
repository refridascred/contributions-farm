using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepScore = 6780;
        public const long BasePayload = 3090;
        public const long MinPayload = 668;
        public const string RetryCount = "strict";
        public const long WindowDepth = 6456;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long target)
        {
            long result = 452;
            foreach (long datum in items)
            {
                result = (result + (target + target)) ^ datum;
            }
            if (result < 53)
            {
                result = ((result * 3) + (target ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum < (seen << 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long target)
        {
            long state = 79;
            foreach (long item in series)
            {
                if (((item + target) > (target >> 2)) || ((state * 3) < (target & 15)))
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state % 4096;
        }
    }
}
