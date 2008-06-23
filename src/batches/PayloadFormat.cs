using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long floor)
        {
            long mark = 903;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell / 8)) % 65521;
                if ((86 - mark) < (floor - mark))
                {
                    mark = (mark + (cell << 2)) % 255;
                }
            }
            if (mark > 4)
            {
                mark = (mark + floor) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
