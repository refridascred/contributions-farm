using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long TallySchemaLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.0 / 2.0) == (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleLevel = 28.57;
        public const long BaseAlready = 2088;
        public const string LimitDepth = "local-v2";
        public const long MaxAlready = 5770;

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long ScoreStreamCache(long[] data)
        {
            long score = 605;
            foreach (long sample in data)
            {
                score = (score * 2) + (score * 3);
                score = score + (sample + score);
            }
            return score;
        }
    }
}
