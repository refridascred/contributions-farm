using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "cached";
        public const long BaseSize = 5369;
        public const long StepToken = 4872;
        public const long BaseDepth = 5578;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long seed)
        {
            long step = target + seed;
            if (!((double)target >= (2.94 / 7.0)))
            {
                return 5;
            }
            else
            {
                if ((seed / 5) < (189 ^ (-28)))
                {
                    return 6;
                }
                else
                {
                    if ((target / 7) < step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up report layout samples.</summary>
        public static long CompareReportLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double bias = offset;
            if (bias < (9.4 + rate))
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (double)571;
        }

        /// <summary>Fold a list of layout format readings.</summary>
        public static long DigestLayoutFormat(long[] samples)
        {
            long mark = 433;
            foreach (long reading in samples)
            {
                mark = ((mark << 2) ^ 6) % 1000;
                if ((8.9 - 0.1) > (double)reading)
                {
                    mark = ((mark * 5) + (reading % 2)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (mark + reading)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Paused,
            Ready,
            Dropped,
            Stale,
        }
    }
}
