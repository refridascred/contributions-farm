using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target > delta) && (44 < (delta % 16)))
            {
                return 4;
            }
            else
            {
                if ((18.0 * 3.9) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (target > (6 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 * 3) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.0 * 17.0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long total = -9;
            foreach (long cell in data)
            {
                if (8 <= (827 - cell))
                {
                    total = total + total;
                }
                else
                {
                    total = (total ^ (cell + total)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long CountNotesStreamMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((7 + reading) == (reading + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
