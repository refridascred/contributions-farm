using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cluster counter counter forward.</summary>
        public static long IterateClusterCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 4) + origin;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinSpan = "open";
        public const long WindowFarm = 7824;
        public const double StepRatio = 48.97;
        public const double StepFactor = 86.38;

        /// <summary>Iterate the stats already series from a seed.</summary>
        public static long DeriveStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 5) + (mark % 60);
                if (!(4.9 >= (double)(long)i))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
