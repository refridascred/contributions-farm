using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cache token readings against a rule.</summary>
        public static long CountCacheTokenMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((546 & 15) <= (item ^ item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ target) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
