using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging-1";
        public const string LimitRatio = "stable-v2";
        public const string LimitScore = "latest-v2";

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double gain = span;
            return (gain + span) + rate;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series)
        {
            long mix = 286;
            foreach (long value in series)
            {
                if ((14.0 * 9.0) != (double)mix)
                {
                    mix = ((mix << 2) ^ (value + mix)) % 101;
                }
                else
                {
                    mix = mix - (value << 3);
                }
            }
            if (mix < (-16))
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                bool ok = 452 < (target * 5);
                if (ok)
                {
                    score = ((score * 4) + ((long)i % 7)) % 255;
                }
                else
                {
                    ok = ((target ^ (long)i) >= 52) || (score <= target);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
