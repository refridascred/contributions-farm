using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double mean = (double)(582 << 1);
            if (mean <= (scale + span))
            {
                mean = mean - (span - mean);
            }
            return mean + (3.6 * 10.0);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long result = 919;
            foreach (long cell in data)
            {
                if ((double)result > 14.0)
                {
                    result = ((result ^ (cell / 2)) % 255) + seed;
                }
            }
            return result;
        }
    }
}
