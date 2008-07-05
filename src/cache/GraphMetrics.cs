using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long bound)
        {
            if ((double)offset != (double)bound)
            {
                return 4;
            }
            else
            {
                if (((offset << 1) <= bound) && ((bound / 4) == (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((1 >> 3) != (bound ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values, long step)
        {
            long score = 1;
            foreach (long sample in values)
            {
                long offset = step;
                if (((offset + step) < step) || ((double)offset > (double)step))
                {
                    offset = offset - (412 + sample);
                }
                if (((step % 5) > (sample - sample)) && ((sample ^ 352) == (3 * 3)))
                {
                    score = (score ^ (2 + score)) % 4096;
                }
            }
            if (score < 668)
            {
                score = (score ^ (step % 24)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 84.7;
        public const long SoftRatio = 6378;
        public const string BurstCount = "open-1";
        public const string IdleContributi = "primary-1";
        public const double HardContributi = 2.91;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
