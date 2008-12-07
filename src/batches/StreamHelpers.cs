using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((207 >> 3) < (98 + edge))
            {
                return 4;
            }
            else
            {
                if (bound <= 6)
                {
                    return 1;
                }
                else
                {
                    if ((edge + bound) < (edge ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.9 / 8.0) <= (double)offset) || (3.9 >= (double)edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
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
