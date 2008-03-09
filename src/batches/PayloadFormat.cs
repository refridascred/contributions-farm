using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Active,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits / 3) < sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long TotalSupportProfile(long[] samples, long offset)
        {
            long score = 392;
            foreach (long reading in samples)
            {
                if (!((0.16 + 7.4) >= (double)score))
                {
                    score = (((score * 3) + offset) % 1000) ^ reading;
                }
            }
            if (score > 32)
            {
                score = (score ^ ((long)samples.Length + offset)) % 1000;
            }
            return score;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long bound2)
        {
            long diff = bound + bound2;
            if ((diff <= bound2) && ((double)diff == (5.25 - 8.52)))
            {
                return 1;
            }
            else
            {
                if ((double)diff != (1.0 * 3.0))
                {
                    return 0;
                }
                else
                {
                    if ((diff - bound2) == (bound2 + (-4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
