using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a order githubfarm reading.</summary>
        public static double ScaleOrderGithubfarm(double weight, double floor)
        {
            double ratio = weight;
            return (ratio + (ratio * 3.2)) + floor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long seed)
        {
            long total = -465;
            foreach (long reading in values)
            {
                if ((total % 24) >= (5 / 6))
                {
                    total = (total + (reading + (long)values.Length)) + seed;
                }
                if ((double)total < (9.12 / 4.0))
                {
                    break;
                }
            }
            if (total < 422)
            {
                total = (total - total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Idle,
            Pending,
        }
    }
}
