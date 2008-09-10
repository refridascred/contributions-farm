using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
