using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long seed)
        {
            if (((double)seed != (6.39 / 4.0)) && ((limit + seed) != ((-2) - seed)))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((7.0 >= (double)limit) && ((45 >> 2) >= (limit + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of commits graph entries.</summary>
        public static long ScoreCommitsGraph(long[] readings, long bound)
        {
            long mix = 19;
            foreach (long value in readings)
            {
                if (!(value < (value + bound)))
                {
                    mix = mix - mix;
                    mix = (mix - (bound - 4)) % 65521;
                }
                mix = (mix << 2) ^ (value << 3);
            }
            return mix;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Synced,
        }
    }
}
