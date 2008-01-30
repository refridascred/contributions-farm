using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a filter githubfarm counter forward.</summary>
        public static long SeriesFilterGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 2) ^ ((long)i - (long)i2)) % 101;
                }
                state = (state ^ (state + state)) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long floor)
        {
            if (((double)floor <= (2.26 / 6.0)) || (limit >= 32))
            {
                return 7;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (105 <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-396) << 1) >= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double gain2 = span + (double)36;
            return (gain2 - span) + gain;
        }

        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long TallyBufferCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((0.5 + 6.57) > (double)(long)samples.Length)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks payload sample.</summary>
        public static long FindChecksPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) >= (entry << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
