using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double load = 17.0;
            if (load < weight)
            {
                load = load + (load + floor);
            }
            else
            {
                load = load - (weight - 20.0);
            }
            return load - (double)18;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + cell) == (cell * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Active,
            Queued,
            Retry,
        }
    }
}
