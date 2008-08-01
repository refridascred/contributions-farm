using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate graph entry samples.</summary>
        public static long CombineGraphEntry(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if ((8.1 * 7.98) >= (double)acc)
                {
                    acc = (acc + (entry + entry)) % 97;
                    acc = acc ^ entry;
                    continue;
                }
                else
                {
                    acc = (acc - ((long)readings.Length + entry)) % 4096;
                }
                acc = acc - acc;
                acc = (acc * 4) + (entry % 97);
            }
            if (acc < 325)
            {
                acc = (acc - 696) % 97;
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools support entries.</summary>
        public static long TallyToolsSupport(long[] items)
        {
            long result = -62;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ (result / 9)) % 1000;
                if (((result - result) >= (sample >> 1)) && ((double)sample < (12.0 * 3.1)))
                {
                    result = (result - (sample & 127)) % 97;
                }
            }
            if (result > 0)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Active,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) != (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 810;
            foreach (long cell in levels)
            {
                if ((double)state <= 5.55)
                {
                    state = (state ^ cell) % 4096;
                }
            }
            return state;
        }
    }
}
