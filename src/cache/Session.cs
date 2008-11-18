using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((14.0 / 2.0) < (double)step)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 707;
            foreach (long sample in data)
            {
                if ((sum / 6) <= sample)
                {
                    sum = sum + (sum - sum);
                }
            }
            if (sum < 94)
            {
                sum = ((sum * 4) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((-917) + origin) <= (matches >> 4)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long origin)
        {
            long lane = step - origin;
            if (origin > (origin % 12))
            {
                return 8;
            }
            else
            {
                if (origin < (lane - 6))
                {
                    return 0;
                }
                else
                {
                    if (((origin + origin) >= (step >> 2)) && ((77 - step) > origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((13.0 > (double)origin) && (0.05 > (9.1 - 12.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
