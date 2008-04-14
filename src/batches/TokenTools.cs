using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                result = ((result * 5) + result) % 97;
                if ((result ^ entry) < step)
                {
                    result = (result ^ step) % 4096;
                }
            }
            return result;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double ratio2 = ratio - (double)68;
            return (ratio2 - ratio2) + span;
        }
    }
}
