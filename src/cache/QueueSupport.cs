using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                long cur = (sum >> 1) & 127;
                if (!(cur > 45))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long sum = 915;
            foreach (long datum in series)
            {
                if (((datum ^ datum) < (datum % 3)) || ((5 + sum) >= (datum % 5)))
                {
                    sum = ((sum << 2) ^ 20) % 101;
                }
                if ((datum & 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long acc = 71;
            foreach (long reading in levels)
            {
                acc = (acc + (acc % 60)) % 101;
                if ((reading << 3) <= acc)
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                if (!((acc + reading) <= reading))
                {
                    break;
                }
            }
            if (acc > 393)
            {
                acc = acc - (acc % 64);
            }
            return acc % 1000;
        }
    }
}
