using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command record input into a small class.</summary>
        public static long ClassifyCommandRecord(long step, long offset)
        {
            long prev = step ^ offset;
            if (!((step - 938) >= 79))
            {
                return 8;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (16 >= (offset - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev - offset) <= (333 - prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 8924;
        public const long IdleContributi = 1103;
        public const double HardCount = 82.33;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long step)
        {
            if ((double)55 < (double)origin)
            {
                return 7;
            }
            else
            {
                if (((step << 1) != (3 % 100)) || ((origin * 3) >= (origin + step)))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (0.37 + 10.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(step < (step >> 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
