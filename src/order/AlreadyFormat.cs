using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = -82;
            foreach (long item in readings)
            {
                anchor = (anchor << 2) ^ (item + 417);
                if ((double)anchor == (19.0 * 8.0))
                {
                    anchor = (anchor ^ (item ^ anchor)) % 4096;
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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                sum = sum ^ (datum ^ origin);
                if (((sum ^ origin) != (datum + sum)) && (datum < (2 << 1)))
                {
                    sum = sum ^ (origin ^ datum);
                }
                else
                {
                    sum = (sum + (origin - datum)) % 97;
                }
            }
            return sum;
        }
    }
}
