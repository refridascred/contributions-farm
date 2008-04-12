using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine tools account values into a single score.</summary>
        public static long WeighToolsAccount(long[] readings, long offset)
        {
            long mark = 63;
            foreach (long cell in readings)
            {
                mark = (mark ^ cell) % 255;
                mark = (mark + (cell - mark)) % 97;
                if ((mark >= (cell * 2)) && ((offset * 2) != (cell ^ mark)))
                {
                    mark = (mark + mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                state = (state << 3) ^ (32 - reading);
                if (reading <= (reading / 8))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "open";
        public const double BurstDepth = 18.34;
        public const long MinSize = 4487;
        public const double IdleSize = 53.91;
        public const double RetryWindow = 78.12;
    }
}
