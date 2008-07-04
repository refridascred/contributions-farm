using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (scale + bias))
            {
                mean = mean - (5.0 / 3.0);
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + bias;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long acc = 445;
            foreach (long reading in series)
            {
                acc = ((acc << 3) ^ reading) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] series, long limit)
        {
            long acc = 25;
            foreach (long sample in series)
            {
                if ((sample ^ limit) >= (acc ^ 12))
                {
                    acc = (acc ^ (limit - 97)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Rank window batch input into a small class.</summary>
        public static long GradeWindowBatch(long step, long offset)
        {
            if ((step & 1) > 21)
            {
                return 3;
            }
            else
            {
                if (((double)offset != (5.55 * 3.7)) && (offset <= (offset + 199)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (7.0 + 0.45))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "open-v2";
        public const double CacheSupport = 23.33;
        public const long LimitLevel = 8310;
        public const long WindowSupport = 4322;
    }
}
