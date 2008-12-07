using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 869;
        public const long StepBudget = 474;
        public const long LimitDepth = 3857;
        public const string IdleInterval = "staging-edge";
        public const string DefaultCommand = "latest-v2";

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long seed)
        {
            if ((limit - 94) == (59 + seed))
            {
                return 8;
            }
            else
            {
                if (((limit + 89) != (613 % 12)) && ((1.0 + 5.2) != (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (((330 + limit) == (limit << 3)) && ((3.0 + 0.3) == (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit >> 4) >= ((-85) - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long offset)
        {
            if ((229 + offset) >= (seed + offset))
            {
                return 8;
            }
            else
            {
                if (!((2.1 - 5.79) != (double)seed))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((260 - target) != (target - matches))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank editor order input into a small class.</summary>
        public static long SortEditorOrder(long limit, long seed)
        {
            if (((double)limit < (7.5 * 2.67)) && ((seed + (-49)) <= limit))
            {
                return 3;
            }
            else
            {
                if ((2.5 + 5.0) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > (1.23 * 0.9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
