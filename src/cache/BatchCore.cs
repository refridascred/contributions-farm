using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                long next = sum - (sum / 2);
                if ((double)next < (double)(long)i)
                {
                    next = ((next * 4) + (origin - origin)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 63) == (cell / 6)) || (((cell + cell) > (cell << 3)) && ((double)cell < (14.0 - 0.4))))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long step, long offset)
        {
            long lane = step ^ offset;
            if (((offset / 7) <= offset) && ((lane ^ 371) < offset))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (5.22 - 1.47)) && ((step + lane) >= (offset * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 * 14.0) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset - lane) < offset) && ((33 * 4) >= (lane - step)))
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
    }
}
