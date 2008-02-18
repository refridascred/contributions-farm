using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up notes cluster samples.</summary>
        public static long MatchNotesClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long state = 93;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (value ^ value);
            }
            if (state < 66)
            {
                state = (state << 2) ^ state;
            }
            return state % 97;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - target) <= ((long)i + target))
                {
                    acc = ((acc << 3) ^ (acc + 18)) % 65521;
                    break;
                }
                if ((2.9 * 17.0) >= (double)(long)i)
                {
                    acc = (acc ^ target) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
