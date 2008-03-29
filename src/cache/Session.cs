using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (8.76 > (double)hits)
                {
                    hits = ((hits + 3) ^ value) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long step)
        {
            long lane = offset ^ step;
            if ((lane + (-263)) != (lane >> 3))
            {
                return 1;
            }
            else
            {
                if ((offset >= (step & 63)) && ((3.0 * 2.0) > (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step < (3.0 + 7.42))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Done,
            Synced,
            Active,
            Ready,
        }
    }
}
