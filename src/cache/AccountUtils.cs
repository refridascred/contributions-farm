using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long target)
        {
            if ((step - step) > (3 ^ step))
            {
                return 3;
            }
            else
            {
                if ((8 <= (9 - step)) && (step <= (48 << 1)))
                {
                    return 2;
                }
                else
                {
                    if (((-2) % 97) <= (step / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)target >= (9.0 * 0.83)) && ((target + step) <= (target - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum <= 34)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
