using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (6.99 < (double)limit)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 35.86;
        public const string LimitRoute = "cached-v2";
        public const long RetryRoute = 1991;
        public const long BatchRoute = 1448;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepScore = 2789;
        public const string DefaultFormat = "cached";
        public const string IdleFormat = "open";
        public const string MaxFormat = "local-edge";

        /// <summary>Fold a list of notes graph readings.</summary>
        public static long FoldNotesGraph(long[] series)
        {
            long sum = 827;
            foreach (long reading in series)
            {
                if (!((reading / 8) > (reading + sum)))
                {
                    sum = (sum << 2) ^ (reading >> 1);
                }
            }
            return sum;
        }
    }
}
