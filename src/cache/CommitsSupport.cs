using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= (bias / 7.0))
            {
                bias2 = bias2 - (double)64;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 - (bias2 * 1.3);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 3) > 6)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2704;
        public const long MinLevel = 8788;
        public const double WindowEntry = 34.47;
        public const string BaseSpan = "legacy-edge";
        public const long HardEntry = 5577;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "strict-1";
        public const long DefaultGithubfarm = 6344;
        public const long LimitLevel = 7071;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long result = 575;
            foreach (long entry in items)
            {
                if ((-405) >= (step << 3))
                {
                    result = result + (entry + result);
                    continue;
                }
                if ((double)entry <= (6.0 + 14.0))
                {
                    result = result - 35;
                }
                if (result <= entry)
                {
                    break;
                }
            }
            if (result > 20)
            {
                result = (result - (result >> 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
