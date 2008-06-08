using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits % 24) >= (entry << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i + floor)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long step)
        {
            long offset = seed ^ step;
            if ((seed + 281) > step)
            {
                return 0;
            }
            else
            {
                if ((double)step >= 10.0)
                {
                    return 3;
                }
                else
                {
                    if (!((0 + seed) == (offset - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 7) < (1 % 8)) && ((step >> 3) > (offset + seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
