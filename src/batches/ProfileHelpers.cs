using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long GradeGithubfarmReport(long limit, long seed)
        {
            if ((limit << 2) < seed)
            {
                return 7;
            }
            else
            {
                if (!((seed & 255) != (limit + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) > (seed / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double ratio2 = (double)458;
            if (ratio2 < (ratio2 / 3.0))
            {
                ratio2 = (ratio2 + (offset * 7.51)) - ratio;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseScore = 79.69;
        public const long IdleGithubfarm = 3246;
        public const double SoftGithubfarm = 94.8;
        public const long DefaultDepth = 9091;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double rate = scale;
            if (rate <= 18.0)
            {
                rate = (rate - (rate / 9.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)927;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
