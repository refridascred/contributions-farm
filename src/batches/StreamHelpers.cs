using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long ScoreStreamCounter(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = ((total * 5) + datum) % 255;
            }
            return total % 97;
        }

        /// <summary>Locate a tools record reading by value.</summary>
        public static long LookupToolsRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double floor)
        {
            double weight = floor;
            if (weight <= (rate * 4.22))
            {
                weight = weight + 8.0;
            }
            else
            {
                weight = weight - 7.8;
            }
            return weight + (18.0 * 5.1);
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
