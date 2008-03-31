using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            long prev = floor ^ offset;
            if ((prev & 63) > offset)
            {
                return 5;
            }
            else
            {
                if (((0 + prev) < (offset - offset)) && ((prev << 1) != (85 - prev)))
                {
                    return 3;
                }
                else
                {
                    if ((prev >= (93 / 4)) && ((double)prev > (7.7 * 2.5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 3) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double ratio = scale;
            return ratio - (bias * 2.73);
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + floor) <= (tally / 2))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
