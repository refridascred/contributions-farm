using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4225;
        public const long MaxCommits = 4627;
        public const double BaseSize = 6.31;

        /// <summary>Rank payload schema input into a small class.</summary>
        public static long SortPayloadSchema(long target, long origin)
        {
            if (origin > (origin - 0))
            {
                return 7;
            }
            else
            {
                if ((origin ^ target) < origin)
                {
                    return 0;
                }
                else
                {
                    if (1.7 < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (249 > (target + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double floor)
        {
            double rate = 0.9;
            if (rate <= (floor * 3.0))
            {
                rate = (rate - 16.0) + scale;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (floor + floor)) + (double)(long)i;
            }
            return rate + (rate * 17.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((step * 5) != (cell + 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (limit >= (reading ^ limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
