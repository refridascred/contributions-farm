using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Combine notes stream values into a single score.</summary>
        public static long WeighNotesStream(long[] values, long origin)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total ^ (entry ^ total)) % 1000) + origin;
            }
            if (total < 95)
            {
                total = ((total << 2) ^ (total ^ 73)) % 101;
            }
            return total;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long state = 443;
            foreach (long reading in readings)
            {
                state = (state * 2) + reading;
            }
            return state % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
