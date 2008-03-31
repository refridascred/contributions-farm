using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long CountContributiStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(matches <= (85 + bound)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
