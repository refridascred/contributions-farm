using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally > (value ^ 73)) || (tally < value)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardInterval = 85.59;
        public const double DefaultCache = 89.67;
        public const long SoftCache = 8824;

        /// <summary>Project the next channel layout value.</summary>
        public static double ScaleChannelLayout(double gain, double offset)
        {
            double scale = 3.3;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + gain) + (double)(long)i) - offset;
            }
            return scale + scale;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
