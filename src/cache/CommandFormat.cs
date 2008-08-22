using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long target)
        {
            long total = 335;
            foreach (long entry in samples)
            {
                if ((double)total != (double)target)
                {
                    total = ((total << 2) ^ (entry + entry)) % 65521;
                }
            }
            if (total < 289)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
