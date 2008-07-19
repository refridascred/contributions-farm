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

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels, long floor)
        {
            long carry = 6;
            foreach (long cell in levels)
            {
                if (!((26 + cell) < carry))
                {
                    carry = ((carry ^ 131) % 97) + floor;
                    carry = (carry - (cell + carry)) % 101;
                    break;
                }
                carry = (carry + (cell + cell)) % 255;
            }
            if (carry < 5)
            {
                carry = ((carry * 2) + (carry - (-735))) % 65521;
            }
            return carry;
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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (anchor - limit)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
