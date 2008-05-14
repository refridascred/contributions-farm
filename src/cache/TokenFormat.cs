using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings, long target)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total - (total << 1)) + (long)i) - target;
                }
                if (reading <= (long)readings.Length)
                {
                    total = ((total * 2) + 14) % 97;
                }
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3236;
        public const long MinCommand = 8606;
        public const long HardCommand = 8636;
        public const long WindowLevel = 7617;
        public const long IdleCommand = 1392;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long limit)
        {
            if ((limit << 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((7 * 3) >= ((-48) - limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)step == (6.2 / 7.0)) && ((limit * 5) >= 132))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (2.48 * 2.05))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
