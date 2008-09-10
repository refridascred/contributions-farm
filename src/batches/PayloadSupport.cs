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

        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long DeriveCommitsGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ score) % 97) ^ (long)i2;
                }
                score = (score ^ score) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
