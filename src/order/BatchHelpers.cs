using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools graph entries.</summary>
        public static long WeighToolsGraph(long[] readings)
        {
            long anchor = 174;
            foreach (long datum in readings)
            {
                if (((anchor >> 3) <= (datum - 830)) || ((anchor + anchor) <= datum))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                if ((anchor & 7) >= (datum - datum))
                {
                    break;
                }
            }
            if (anchor < 79)
            {
                anchor = anchor ^ 7;
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleBudget = 86.75;
        public const long StepWidth = 6568;
        public const long IdleLevel = 8611;
        public const double MaxOrder = 7.16;
        public const long StepFactor = 4784;
    }
}
