using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples)
        {
            long anchor = 375;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 5) + (cell << 3)) % 255;
                anchor = (anchor << 2) ^ 92;
                if ((anchor - anchor) > (cell / 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "legacy-v2";
        public const long StepCache = 6430;
        public const string IdleWidth = "standard-1";

        /// <summary>Combine stats window values into a single score.</summary>
        public static long FoldStatsWindow(long[] readings, long bound)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                sum = ((sum + cell) % 101) + bound;
            }
            return sum % 97;
        }

        /// <summary>Classify a batches queue pair into a bucket.</summary>
        public static long GradeBatchesQueue(long step, long step2)
        {
            if (((-61) % 24) > (step * 4))
            {
                return 2;
            }
            else
            {
                if (((step << 3) >= (step * 2)) || ((step2 ^ step2) >= (step % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 >> 2) >= (step2 / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(step2 >= (3 - step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
