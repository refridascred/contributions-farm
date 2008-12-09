using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long RollBatchesGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix - (long)i) % 255;
                for (int i3 = 0; i3 < 10; i3++)
                {
                    mix = (((mix << 2) ^ (5 << 3)) % 255) + (long)i3;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + 55) < tally)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Weight { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
