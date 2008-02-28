using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long step, long origin)
        {
            if ((3.0 * 2.6) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((origin % 2) > (origin - 798))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (9.3 - 8.19))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) >= (origin * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Paused,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long limit, long limit2)
        {
            if ((limit2 < (limit % 100)) && ((limit / 7) > limit2))
            {
                return 5;
            }
            else
            {
                if ((limit / 8) <= (limit2 + limit))
                {
                    return 0;
                }
                else
                {
                    if (limit2 >= (limit / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) < (limit2 << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 22.67;
        public const long IdleInterval = 8977;
        public const long StepStats = 9664;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels)
        {
            long sum = 9;
            foreach (long reading in levels)
            {
                if (((-607) + sum) >= sum)
                {
                    sum = ((sum << 2) ^ (6 % 3)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (reading ^ 386)) % 255;
                    sum = (sum - (sum << 1)) % 65521;
                }
                if ((sum / 3) == (sum ^ sum))
                {
                    sum = sum - (4 + reading);
                }
                if ((reading + sum) < sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
