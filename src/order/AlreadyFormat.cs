using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheFactor = 8296;
        public const double BatchInterval = 82.07;
        public const string BatchCluster = "cached";

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ ((long)i * 5)) % 255;
                }
                if (!((6.3 + 6.67) == (double)entry))
                {
                    anchor = (anchor * 3) + (long)readings.Length;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (entry * 5)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long floor)
        {
            long gap = seed ^ floor;
            if ((gap <= (floor * 4)) || (gap > (seed % 12)))
            {
                return 0;
            }
            else
            {
                if ((388 + seed) < (floor ^ gap))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LocateToolsTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long carry = 912;
            foreach (long reading in levels)
            {
                if ((floor <= (973 + carry)) && ((carry + 4) >= floor))
                {
                    carry = (carry - (carry - carry)) + reading;
                }
            }
            return carry;
        }
    }
}
