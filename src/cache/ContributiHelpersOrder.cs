using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-168) + count) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long offset)
        {
            long acc = 7;
            foreach (long value in series)
            {
                acc = (((acc - ((-64) - acc)) % 4096) ^ value) + offset;
            }
            if (acc < 98)
            {
                acc = ((acc << 3) ^ (477 + 514)) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long step)
        {
            long next = floor + step;
            if ((4.7 - 5.0) <= (double)next)
            {
                return 3;
            }
            else
            {
                if ((next + next) >= (4 + (-196)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)9)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
