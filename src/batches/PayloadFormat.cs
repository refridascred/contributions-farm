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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Closed,
            Active,
            New,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            long prev = offset ^ seed;
            if ((seed * 4) <= seed)
            {
                return 3;
            }
            else
            {
                if ((offset << 2) <= (prev % 24))
                {
                    return 5;
                }
                else
                {
                    if ((3.4 + 7.1) != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
