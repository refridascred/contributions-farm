using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank session batches input into a small class.</summary>
        public static long RankSessionBatches(long bound, long seed)
        {
            long cur = bound - seed;
            if (((seed % 2) == (cur + 341)) || (((-5) - 89) < (seed - cur)))
            {
                return 0;
            }
            else
            {
                if (cur > bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur >> 2) == ((-673) + cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double gain = scale - scale;
            if (gain < scale)
            {
                gain = (gain + gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((422 + reading) <= (tally - (long)readings.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(seen <= (seen >> 5)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
