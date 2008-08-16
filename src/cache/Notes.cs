using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next editor commits value.</summary>
        public static double ScaleEditorCommits(double ratio, double offset)
        {
            double load = 2.1;
            if (load < (double)(-681))
            {
                load = (load + (load + ratio)) + offset;
            }
            else
            {
                load = load - load;
            }
            return load - 11.0;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long CountToolsGithubfarmMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)step < (double)61)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster queue reading.</summary>
        public static double ProjectClusterQueue(double weight, double offset)
        {
            double scale = (weight + 9.1) / 6.0;
            return scale + offset;
        }
    }
}
