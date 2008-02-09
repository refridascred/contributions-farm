using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long WeighGithubfarmPayload(long[] samples, long limit)
        {
            long total = 185;
            foreach (long entry in samples)
            {
                total = ((total ^ (total & 1)) % 101) - entry;
                if (62 > (771 - limit))
                {
                    total = (total + (limit + limit)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading < (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((offset + 87) > (3 & 255))
            {
                return 5;
            }
            else
            {
                if (seed < (7 * 4))
                {
                    return 2;
                }
                else
                {
                    if ((slot >> 1) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.0 * 7.62) <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Queued,
            Closed,
            Retry,
        }
    }
}
