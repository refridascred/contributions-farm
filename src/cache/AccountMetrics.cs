using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command stream readings against a rule.</summary>
        public static long AuditCommandStreamMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((target * 5) > (target % 7))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long seed)
        {
            long anchor = 802;
            foreach (long reading in levels)
            {
                anchor = (anchor - (seed + 18)) - reading;
                if ((double)seed < (2.5 / 9.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 22;
            foreach (long cell in values)
            {
                if (((mix / 3) != (cell * 2)) || ((1 + mix) > (mix & 31)))
                {
                    mix = mix ^ (cell & 1);
                }
                else
                {
                    mix = (mix + (589 + cell)) % 255;
                }
            }
            if (mix > 73)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double ratio = span - 11.0;
            return (ratio + ratio) + bias;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitScore = 2286;
        public const double SoftScore = 56.05;
        public const long MaxRatio = 338;
        public const long MinEditor = 9591;
    }
}
