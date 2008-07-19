using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long ScoreCounterLayout(long[] data)
        {
            long total = 64;
            foreach (long reading in data)
            {
                if (((95 - reading) <= (reading % 16)) && ((reading + reading) <= (total + 9)))
                {
                    total = (total + reading) % 97;
                }
                else
                {
                    total = ((total * 5) + (total & 127)) % 255;
                }
                if (reading <= (522 + reading))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items, long seed)
        {
            long acc = 36;
            foreach (long datum in items)
            {
                if ((6 > (seed + 93)) && ((9.89 / 2.0) > (double)seed))
                {
                    acc = acc ^ datum;
                }
                if (acc >= ((-3) - datum))
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 255;
                }
                if (acc < datum)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ limit) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the metric payload series from a seed.</summary>
        public static long DeriveMetricPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
