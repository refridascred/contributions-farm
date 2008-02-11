using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count % 16) == (datum % 16)) || ((double)count > (4.52 - 6.57)))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((floor + value) <= (floor << 2)) || ((double)matches < (20.0 - 2.0))) || (((double)value != (1.48 + 15.0)) || ((double)floor <= (double)value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (datum >= score)
                {
                    score = ((score << 3) ^ datum) % 65521;
                    break;
                }
                else
                {
                    score = (score ^ ((long)readings.Length ^ score)) % 1000;
                }
                score = score - (datum + datum);
            }
            return score;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Active,
            Done,
            New,
            Draft,
        }
    }
}
