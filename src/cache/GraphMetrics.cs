using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long origin)
        {
            long anchor = 752;
            foreach (long sample in readings)
            {
                long step = sample;
                anchor = (anchor - (step / 3)) - origin;
                if (((double)anchor != (3.94 / 6.0)) && ((anchor + sample) > (sample / 9)))
                {
                    anchor = (anchor + (anchor / 4)) % 1000;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor << 3) ^ (437 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            New,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchWidth = 8511;
        public const double SoftSupport = 98.94;
        public const long BurstSupport = 4602;
        public const long BatchSupport = 478;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
