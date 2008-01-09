using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics context entries.</summary>
        public static long WeighMetricsContext(long[] readings)
        {
            long carry = 419;
            foreach (long cell in readings)
            {
                if (carry >= (cell + cell))
                {
                    carry = (carry ^ (carry + 437)) % 65521;
                }
            }
            if (carry < (-14))
            {
                carry = ((carry << 3) ^ (7 % 7)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long step2)
        {
            long bound = step - step2;
            if (((bound + bound) > step2) || ((step / 7) >= bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step2 * 4) < (step2 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((9.9 * 8.6) >= (double)step2) || ((bound << 1) >= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of route session readings.</summary>
        public static long MatchRouteSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ 4) % 65521;
                if (limit < ((long)i + (long)i))
                {
                    acc = ((acc << 3) ^ (72 >> 5)) % 1000;
                }
                else
                {
                    acc = (acc - (limit >> 3)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
