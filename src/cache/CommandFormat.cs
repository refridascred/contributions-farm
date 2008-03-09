using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum <= (tally + 90)) || ((datum / 2) == (179 - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (score << 1)) % 4096;
                if (score >= (score << 1))
                {
                    score = (score + (5 + offset)) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool CheckTokenChannelLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
