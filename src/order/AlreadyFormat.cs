using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a counter format pair into a bucket.</summary>
        public static long RankCounterFormat(long floor, long bound)
        {
            long prev = floor + bound;
            if (!((floor << 1) >= (17 - bound)))
            {
                return 2;
            }
            else
            {
                if (floor > (615 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ bound) >= (floor & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((prev & 255) != (prev % 24)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long DigestCommandCluster(long[] levels)
        {
            long mark = 28;
            foreach (long value in levels)
            {
                if ((value % 7) >= (value + mark))
                {
                    mark = (mark - (value % 10)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
