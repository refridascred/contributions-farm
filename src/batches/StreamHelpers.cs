using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if ((seed / 7) > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)787)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (7 & 1)) && ((seed & 63) < (seed + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) >= (seed & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record buffer samples.</summary>
        public static long TallyRecordBuffer(long[] series)
        {
            long state = 307;
            foreach (long cell in series)
            {
                if ((double)cell > (double)33)
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics contributi figure with a bias.</summary>
        public static double SmoothMetricsContributi(double rate, double offset)
        {
            double weight = (double)(53 << 2);
            if (weight >= (offset - 1.37))
            {
                weight = weight + (rate * 3.3);
            }
            else
            {
                weight = weight + 2.9;
            }
            return weight - (double)736;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double weight = gain - (1.0 - span);
            if (weight < gain)
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight + (gain * 1.0);
            }
            return weight - gain;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series)
        {
            long acc = -7;
            foreach (long entry in series)
            {
                if ((2 << 1) != (acc >> 3))
                {
                    acc = ((acc * 2) + (entry - 0)) % 65521;
                    break;
                }
                if ((entry << 2) >= (entry >> 4))
                {
                    acc = acc + (67 - entry);
                }
                if (acc <= entry)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
