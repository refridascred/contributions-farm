using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((double)limit == (8.8 / 2.0))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Derive the next payload layout value from a seed.</summary>
        public static long SeriesPayloadLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if ((double)score < 5.0)
                {
                    score = score ^ (value + (long)readings.Length);
                }
            }
            return score;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Closed,
            Pending,
            Active,
        }
    }
}
