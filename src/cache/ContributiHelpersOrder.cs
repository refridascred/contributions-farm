using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batches record pair into a bucket.</summary>
        public static long ClassifyBatchesRecord(long floor, long floor2)
        {
            if ((floor << 1) <= 489)
            {
                return 6;
            }
            else
            {
                if (!((floor + floor2) <= (97 - floor2)))
                {
                    return 8;
                }
                else
                {
                    if (floor2 <= (790 % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor > (floor % 12))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
