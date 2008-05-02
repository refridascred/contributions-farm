using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                score = (score ^ (entry ^ entry)) % 1000;
            }
            return score;
        }

        /// <summary>Combine layout filter values into a single score.</summary>
        public static long TallyLayoutFilter(long[] levels, long floor)
        {
            long score = 22;
            foreach (long reading in levels)
            {
                if ((double)floor >= 9.0)
                {
                    score = ((score << 3) ^ (reading ^ 8)) % 4096;
                }
                score = ((score * 3) + floor) % 255;
                if (316 <= (44 + reading))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = (score + (floor * 4)) % 101;
            }
            return score;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
