using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long bound)
        {
            long delta = origin + bound;
            if ((double)delta != (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)delta < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound >= (double)1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
