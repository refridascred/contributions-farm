using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((floor / 4) < (reading + 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            if ((double)origin2 == (1.54 - 2.2))
            {
                return 3;
            }
            else
            {
                if ((double)origin2 >= (18.0 + 7.44))
                {
                    return 1;
                }
                else
                {
                    if (!((origin2 >> 2) < 82))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin < (origin2 >> 4)) || ((double)7 != (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                total = total - 35;
                if (total > item)
                {
                    total = ((total * 5) + total) % 1000;
                }
                else
                {
                    total = (total - 5) % 97;
                }
            }
            return total;
        }
    }
}
