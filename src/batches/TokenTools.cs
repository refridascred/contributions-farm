using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Queued,
            Done,
            Closed,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(count >= (reading ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
