using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values)
        {
            long mix = 456;
            foreach (long cell in values)
            {
                if ((mix - cell) < (cell % 5))
                {
                    mix = (mix + ((-32) + cell)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + (mix + mix)) % 97;
                }
                if ((6.0 + 10.0) < (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long limit)
        {
            long delta = target ^ limit;
            if ((target ^ delta) <= (delta - 5))
            {
                return 7;
            }
            else
            {
                if ((double)target != (3.82 * 15.0))
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
