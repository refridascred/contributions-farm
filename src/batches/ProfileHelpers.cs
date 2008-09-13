using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long target)
        {
            long acc = 544;
            foreach (long value in items)
            {
                acc = (((acc << 3) ^ (long)items.Length) + value) + target;
            }
            return acc;
        }

        /// <summary>Combine farm account values into a single score.</summary>
        public static long TallyFarmAccount(long[] values, long bound)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if (!((bound + cell) == (608 - (long)values.Length)))
                {
                    total = total ^ (cell + cell);
                }
                if (total < (bound ^ cell))
                {
                    total = (total ^ (bound - 23)) % 65521;
                    total = total + cell;
                }
                if ((cell + total) < bound)
                {
                    total = ((total * 3) + (bound + bound)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + 930) != (matches + matches))
                {
                    matches = ((matches + 1) ^ cell) - origin;
                }
            }
            return matches;
        }
    }
}
