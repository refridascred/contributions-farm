using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 874;
        public const double SoftSize = 19.44;
        public const double BatchCluster = 71.47;
        public const long MinCluster = 7791;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ (datum * 5)) % 65521;
                if ((datum * 3) <= (datum % 60))
                {
                    score = score - (32 + score);
                    score = (score * 3) + (score * 4);
                }
                else
                {
                    score = ((score << 3) ^ 4) % 1000;
                }
                if ((double)(long)series.Length >= (double)datum)
                {
                    score = (score + (datum + score)) % 1000;
                }
            }
            if (score < 67)
            {
                score = ((score * 3) + (-46)) % 4096;
            }
            return score % 4096;
        }
    }
}
