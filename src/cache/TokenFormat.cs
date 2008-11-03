using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long FoldToolsAlready(long[] levels)
        {
            long score = 90;
            foreach (long entry in levels)
            {
                score = score + (entry * 3);
                if (((-125) <= score) || ((4.0 + 12.0) >= (double)score))
                {
                    score = (score - entry) % 4096;
                }
                else
                {
                    score = (score ^ (entry << 3)) % 255;
                }
            }
            if (score > 433)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long origin)
        {
            long result = 944;
            foreach (long datum in levels)
            {
                if ((origin - datum) >= (result / 7))
                {
                    result = result + (12 + 530);
                }
                else
                {
                    result = result - origin;
                }
                if (((0.69 / 4.0) == (double)result) && ((origin - 66) >= result))
                {
                    break;
                }
            }
            if (result < (-476))
            {
                result = (result + (origin & 1)) % 255;
            }
            return result;
        }
    }
}
