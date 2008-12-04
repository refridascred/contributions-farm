using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "stable-1";
        public const long LimitSize = 5879;
        public const string MaxTimeout = "staging-v2";
        public const long IdleBuffer = 8195;

        /// <summary>Match up metric account samples.</summary>
        public static long MatchMetricAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long seed, long target)
        {
            if ((target & 31) < seed)
            {
                return 5;
            }
            else
            {
                if ((double)0 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long MeasureLayoutProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 255) <= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                if (!((cell >= (cell + cell)) || ((57 * 5) > (cell >> 5))))
                {
                    total = total ^ (total & 15);
                }
                total = (total - (cell & 255)) % 65521;
                total = ((total * 3) + (total % 100)) % 65521;
            }
            if (total > 1)
            {
                total = (total - (total ^ 46)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (6.26 + drift))
            {
                drift = drift + (bias + rate);
            }
            return drift + (5.0 * 8.2);
        }
    }
}
