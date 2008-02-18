using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long BucketSessionEntry(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((double)seed < 11.0)
            {
                return 6;
            }
            else
            {
                if ((seed * 2) == (5 & 31))
                {
                    return 0;
                }
                else
                {
                    if (!((0.2 * 5.0) <= (14.0 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur & 63) > (cur * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long CountStreamContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen << 1) >= seen)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
