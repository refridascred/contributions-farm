using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items)
        {
            long mark = 11;
            foreach (long cell in items)
            {
                mark = (mark * 3) + (cell & 3);
            }
            return mark;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if ((bound >> 4) > limit)
            {
                return 4;
            }
            else
            {
                if ((bound & 255) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "latest";
        public const string IdleLevel = "local";
        public const long BurstAlready = 801;
    }
}
