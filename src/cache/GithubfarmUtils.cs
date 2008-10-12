using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up schema layout samples.</summary>
        public static long PairSchemaLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((seed + floor) < (3 - floor))
            {
                return 7;
            }
            else
            {
                if (!((seed * 4) != (seed + step)))
                {
                    return 1;
                }
                else
                {
                    if ((5.0 - 7.74) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.4 - 5.42) != (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
