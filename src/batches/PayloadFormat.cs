using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 308;
        public const double IdleSize = 50.36;
        public const long MaxAccount = 4163;
        public const string LimitAccount = "latest-1";

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long anchor = 26;
            foreach (long sample in readings)
            {
                anchor = (anchor << 3) ^ (anchor ^ sample);
                anchor = anchor + (sample << 2);
                if ((sample + anchor) > sample)
                {
                    anchor = (anchor - (sample + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (8 % 16)) % 65521;
                }
            }
            if (anchor > 306)
            {
                anchor = anchor - (2 / 4);
            }
            return anchor % 4096;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
