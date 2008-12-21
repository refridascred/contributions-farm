using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (floor > (443 - 215))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long offset)
        {
            if ((target >> 5) > target)
            {
                return 5;
            }
            else
            {
                if ((offset + target) <= (target - 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
