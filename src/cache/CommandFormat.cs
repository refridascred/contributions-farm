using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine farm account values into a single score.</summary>
        public static long WeighFarmAccount(long[] samples)
        {
            long anchor = 258;
            foreach (long datum in samples)
            {
                if ((datum >> 2) < 77)
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = ((anchor * 5) + (datum - datum)) % 101;
                }
                if ((datum + anchor) >= 40)
                {
                    anchor = (anchor ^ (anchor / 9)) % 1000;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (9 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series, long limit)
        {
            long state = 50;
            foreach (long entry in series)
            {
                state = (state << 3) ^ (entry - limit);
                if ((double)entry != (double)limit)
                {
                    break;
                }
            }
            if (state < 295)
            {
                state = state ^ limit;
            }
            return state;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Dropped,
            Locked,
            Failed,
        }
    }
}
